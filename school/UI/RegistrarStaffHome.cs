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
    public partial class RegistrarStaffHome : Form
    {
        public RegistrarStaffHome()
        {
            InitializeComponent();
            comboBox1.Items.Add("Students");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Courses");
            comboBox1.Items.Add("Sections");
            comboBox1.Items.Add("Enrolls");
            comboBox1.Items.Add("Authorizations");
            comboBox1.Items.Add("Fixed Fees");
            comboBox1.Items.Add("Variable Fee Rates");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tableToLoad = Convert.ToString(comboBox1.SelectedItem);

            RegistrarEdit editThis = new RegistrarEdit();
            editThis.Show(tableToLoad);
        }
    }
}
