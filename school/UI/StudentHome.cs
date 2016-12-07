using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class frmStudentHome : Form
    {
        public frmStudentHome()
        {
            InitializeComponent();
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);
            // TODO: This line of code loads data into the 'enquadeDataSet.variableFeeRate' table. You can move, or remove it, as needed.
            // filter table fill based on student's sType and inState status
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);

            // TODO: This line of code loads data into the 'enquadeDataSet.enrolls' table. You can move, or remove it, as needed.
            this.enrollsTableAdapter.Fill(this.enquadeDataSet.enrolls);
            pastEnrollsGridView.DataSource = this.enquadeDataSet.enrolls.Select("grade=''");

            //DataRow authFilter = ((DataRowView)(enquadeDataSet.authorizations.Select("authType='AUTH'"))).Row;
            //authFilter = ;
            //currentEnrollsGridView.DataSource = this.enquadeDataSet.authorizations.Select("authType='AUTH'");
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            // only display sections table info when a class is sucessfully registered for
            //this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.enquadeDataSet.staff);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // register using the id of the logged in user and the crn entered in the form field
            // must clear an AUTH check from the authorizations table first

            //if
        }
    }
}
