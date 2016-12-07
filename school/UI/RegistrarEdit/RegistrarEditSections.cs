using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school.UI.RegistrarEdit
{
    public partial class RegistrarEditSections : Form
    {
        public RegistrarEditSections()
        {
            InitializeComponent();
        }

        private void RegistrarEditSections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sectionsTableAdapter.Update(this.enquadeDataSet.sections);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
