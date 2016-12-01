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
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);
            // TODO: This line of code loads data into the 'enquadeDataSet.variableFeeRate' table. You can move, or remove it, as needed.
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);
            // TODO: This line of code loads data into the 'enquadeDataSet.enrolls' table. You can move, or remove it, as needed.
            this.enrollsTableAdapter.Fill(this.enquadeDataSet.enrolls);
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.enquadeDataSet.staff);

        }
    }
}
