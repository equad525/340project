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

        private List<Enrolls> _enrollsList;
        private List<Sections> _scheduleSections;

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

            _enrollsList = Retrieve<Enrolls>(new List<Condition>()
            {
                new Condition()
                {
                    ConditionOperator = Condition.Operators.Equal,
                    Left = "sid",
                    Right = sid
                }
            });

            if(_enrollsList.Count > 0)
            {
                _crn = _enrollsList[0];

                _sec = Retrieve<Sections>(new List<Condition>()
                {
                    new Condition()
                    {
                        ConditionOperator = Condition.Operators.Equal,
                        Left = "crn",
                        Right = _crn.Crn.ToString()
                    }
                })[0];
            }

            this.enrollsBindingSource1.Filter = "sid ='" + _sid.Sid.ToString() + "'";
            this.variableFeeRateBindingSource.Filter = "sType ='" + _sid.SType + 
                                                "' AND inOrOutOfState ='" + stateStatus + "'";
           // this.sectionsBindingSource1.Filter = "crn ='" + _sec.Crn.ToString() + "'";
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
            // TODO: This line of code loads data into the 'enquadeDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
            // TODO: This line of code loads data into the 'enquadeDataSet.variableFeeRate' table. You can move, or remove it, as needed.
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);
            // TODO: This line of code loads data into the 'enquadeDataSet.enrolls' table. You can move, or remove it, as needed.
            this.enrollsTableAdapter.Fill(this.enquadeDataSet.enrolls);
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);

            RefreshCurrentSchedule();

            DataTable cboStudentSelection = new DataView(this.enquadeDataSet.students).ToTable(true, "sid");
            cboStudent.DataSource = cboStudentSelection.Select("sid=" + _sid.Sid.ToString()).CopyToDataTable();
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
                Auth = sectionData.Field<string>("auth")
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

            if(newSec.Auth.ToString() == "N" ||
              (_sid.Sid == newAuth.Sid && newAuth.Crn == newSec2.Crn))
            {
                //register in the class
                if (Create<Enrolls>(newEnroll))
                {
                    MessageBox.Show("You enrolled in " + newEnroll.Crn);
                    RefreshCurrentSchedule();
                }
            }
            else
            {
                //deny class registration
                MessageBox.Show("Registration denied for " + newEnroll.Crn);
            }
            
        }

        private void cboRegCrn_Format(object sender, ListControlConvertEventArgs e)
        {
            //this makes sections in the dropdown distinguishable
            string pre = ((DataRowView)e.ListItem).Row.Field<string>("cprefix");
            string crn = ((DataRowView)e.ListItem).Row.Field<int>("crn").ToString();

            e.Value = pre + crn;
        }

        private void RefreshCurrentSchedule()
        {
            //Get Enrolls List
            _enrollsList = Retrieve<Enrolls>(new List<Condition>()
            {
                new Condition()
                {
                    ConditionOperator = Condition.Operators.Equal,
                    Left = "sid",
                    Right = _sid.Sid.ToString()
                }
            });

            if(_enrollsList.Count > 0)
            {
                _crn = _enrollsList[0];
            }

            //Current schedule filter
            _scheduleSections = new List<Sections>();

            foreach (var enrolls in _enrollsList.Where(en => en.Grade == null))
            {
                _scheduleSections.Add(Retrieve<Sections>(new List<Condition>()
                {
                    new Condition("term", Condition.Operators.Equal, enrolls.Term),
                    new Condition("year", Condition.Operators.Equal, enrolls.Year.ToString()),
                    new Condition("crn", Condition.Operators.Equal, enrolls.Crn.ToString())
                })[0]);
            }

            scheduleDataGridView.DataSource = _scheduleSections;

            //Currently enrolled view
            this.enrollsTableAdapter.Fill(this.enquadeDataSet.enrolls);
            this.enrollsBindingSource1.Filter = "sid ='" + _sid.Sid.ToString() + "'";
        }
    }
}
