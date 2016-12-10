using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using static Data.DataAccess;
using schoolWorkVer;
using CourseProject.PD;

namespace school.UI
{
    public partial class frmStudentHome2 : Form
    {
        //private Students students;
        private Students _sid;
        private Enrolls _crn;
        private Sections _sec;

        public frmStudentHome2()
        {
            InitializeComponent();
        }

        public frmStudentHome2(string sid)
        {
            InitializeComponent();
            _sid = Retrieve<Students>(new List<Condition>()
            {
                new Condition()
                {
                    ConditionOperator = Condition.Operators.Equal,
                    Left = "sid",
                    Right = sid
                }
            })[0];

            string stateStatus = "INSTATE";
            if (_sid.InState == "Y")
            {
                stateStatus = "INSTATE";
            }
            else
            {
                stateStatus = "OUTOFSTATE";
            }

            _crn = Retrieve<Enrolls>(new List<Condition>()
            {
                new Condition()
                {
                    ConditionOperator = Condition.Operators.Equal,
                    Left = "sid",
                    Right = sid
                }
            })[0];

            _sec = Retrieve<Sections>(new List<Condition>()
            {
                new Condition()
                {
                    ConditionOperator = Condition.Operators.Equal,
                    Left = "crn",
                    Right = _crn.Crn.ToString()
                }
            })[0];

            this.enrollsBindingSource1.Filter = "sid ='" + _sid.Sid.ToString() + "'";
            this.variableFeeRateBindingSource.Filter = "sType ='" + _sid.SType + 
                                                "' AND inOrOutOfState ='" + stateStatus + "'";
            this.sectionsBindingSource1.Filter = "crn ='" + _sec.Crn.ToString() + "'";
        }

        //public frmStudentHome2(Students students)
        //{
        //    this.students = students;
        //    string stateStatus = "INSTATE";
        //    if (students.InState == "Y")
        //    {
        //        stateStatus = "INSTATE";
        //    }
        //    else
        //    {
        //        stateStatus = "OUTOFSTATE";
        //    }
        //    string filter = "sType ='" + students.SType + "' AND inOrOutOfState ='" + stateStatus + "'";
        //    DataRow[] dataRows = enquadeDataSet.variableFeeRate.Select(filter);
        //    frmStudentHome2 studentForm = new frmStudentHome2();
        //    studentForm.varFeeDataGridView.DataSource = dataRows.CopyToDataTable();
        //    studentForm.Show();
        //    studentForm.Closed += (s, args) => this.Show();;
        //}

        private void frmStudentHome2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.variableFeeRate' table. You can move, or remove it, as needed.
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);
            // TODO: This line of code loads data into the 'enquadeDataSet.enrolls' table. You can move, or remove it, as needed.
            this.enrollsTableAdapter.Fill(this.enquadeDataSet.enrolls);
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);
            
        }

        private void enrollsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataRow studentData = ((DataRowView)cboStudent.SelectedItem).Row;
            DataRow sectionData = ((DataRowView)cboRegCrn.SelectedItem).Row;

            Authorizations newAuth = new Authorizations()
            {
                Sid = studentData.Field<short>("sid"),
                Crn = sectionData.Field<int>("crn"),
                //Term = sectionData.Field<string>("term"),
                //Year = sectionData.Field<short>("year"),
                AuthType = ""
            };

            Sections newSec = new Sections()
            {
                
                //Cap = sectionData.Field<short>("cap"),
                //Auth = sectionData.Field<string>("auth")
            };

            Sections newSec2 = new Sections()
            {
                //Cap = sectionData.Field<short>("cap"),
                Crn = sectionData.Field<int>("crn")

            };

            Enrolls newEnroll = new Enrolls()
            {
                Sid = studentData.Field<short>("sid"),
                Term = sectionData.Field<string>("term"),
                Year = sectionData.Field<short>("year"),
                Crn = sectionData.Field<int>("crn")
            };

            if(newSec.Auth.ToString() == "N")
            {
                //register in the class
                Create<Enrolls>(newEnroll);
                MessageBox.Show("You enrolled in " + newEnroll.Crn);
            }
            else
            {
                if (_sid.Sid == newAuth.Sid && newAuth.Crn == newSec2.Crn)
                {
                    //register in the class
                    Create<Enrolls>(newEnroll);
                    MessageBox.Show("You enrolled in " + newEnroll.Crn);
                }
                //deny class registration
                MessageBox.Show("Registration denied for " + newEnroll.Crn);
            }
            
        }
    }
}
