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

namespace school.UI
{
    public partial class frmStudentHome2 : Form
    {
        private Students students;

        public frmStudentHome2()
        {
            InitializeComponent();
        }

        public frmStudentHome2(Students students)
        {
            this.students = students;
            string stateStatus = "INSTATE";
            if (students.InState == "Y")
            {
                stateStatus = "INSTATE";
            }
            else
            {
                stateStatus = "OUTOFSTATE";
            }
            string filter = "sType ='" + students.SType + "' AND inOrOutOfState ='" + stateStatus + "'";
            DataRow[] dataRows = enquadeDataSet.variableFeeRate.Select(filter);
            frmStudentHome2 studentForm = new frmStudentHome2();
            studentForm.varFeeDataGridView.DataSource = dataRows.CopyToDataTable();
            studentForm.Show();
            studentForm.Closed += (s, args) => this.Show();;
        }

        private void frmStudentHome2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);

        }
    }
}
