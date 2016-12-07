using schoolWorkVer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Data.DataAccess;

namespace school
{
    public partial class frmStudentHome : Form
    {
        public frmStudentHome()
        {
            InitializeComponent();
        }

        public string _txtSudentId { get; set; }
        public string _txtCrn { get; set; }
        public string _txtTerm { get; set; }
        public string _txtYear { get; set; }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);

            // TODO: This line of code loads data into the 'enquadeDataSet.variableFeeRate' table. You can move, or remove it, as needed.
            // filter table fill based on student's sType and inState status
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);

            // TODO: This line of code loads data into the 'enquadeDataSet.enrolls' table. You can move, or remove it, as needed.
            this.enrollsTableAdapter.Fill(this.enquadeDataSet.enrolls);
            //pastEnrollsGridView.DataSource = this.enquadeDataSet.enrolls.Select("grade=''");
            //DataRow authFilter = ((DataRowView)(enquadeDataSet.authorizations.Select("authType='AUTH'"))).Row;
            //authFilter = ;
            //currentEnrollsGridView.DataSource = this.enquadeDataSet.authorizations.Select("authType='AUTH'");

            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            // only display sections table info when a class is sucessfully registered for and enrolls_crn = sections_crn for a particular sid
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);

            // TODO: This line of code loads data into the 'enquadeDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.enquadeDataSet.staff);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // register using the id of the logged in user and the crn entered in the form field
            // must clear an AUTH check from the authorizations table first

            List<Authorizations> auth1 = Retrieve<Authorizations>(
                new List<Condition>()
                {
                    new Condition("sid", Condition.Operators.Equal, _txtSudentId),
                    new Condition("authType", Condition.Operators.Equal, "AUTH"),
                    new Condition("crn", Condition.Operators.Equal, _txtCrn)
                });

            if (auth1.Any<Authorizations>())
            {

                Enrolls newEnroll = new Enrolls()
                {
                    Sid = Convert.ToInt16(_txtSudentId),
                    Crn = Convert.ToInt32(_txtCrn),
                    Term = _txtTerm,
                    Year = Convert.ToInt16(_txtYear),
                    Grade = null
                };
                Create<Enrolls>(newEnroll);
            }
            else
            {
                MessageBox.Show("You are not eligible to register for that class");
            }

            //refresh the sections data grid view with any newly enrolled/registered class?
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
        }

        private void sidTextBox_TextChanged(object sender, EventArgs e)
        {
            _txtSudentId = this.sidTextBox.ToString();
        }

        private void crnTextBox_TextChanged(object sender, EventArgs e)
        {
            _txtCrn = this.crnTextBox.ToString();
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            _txtYear = this.yearTextBox.ToString();
        }

        private void termTextBox_TextChanged(object sender, EventArgs e)
        {
            _txtTerm = this.termTextBox.ToString();
        }
    }
}
