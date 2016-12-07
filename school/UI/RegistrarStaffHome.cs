using school.UI.RegistrarEdit;
using school.UI.RegistratEdit;
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
            switch (tableToLoad)
            {
                case "Students":
                    RegistrarEditStudent student = new RegistrarEditStudent();
                    this.Hide();
                    student.Closed += (s, args) => this.Show();
                    student.Show(); break;
                case "Staff":
                    RegistrarEditStaff staff = new RegistrarEditStaff();
                    this.Hide();
                    staff.Closed += (s, args) => this.Show();
                    staff.Show(); break;
                case "Courses":
                    RegistrarEditCourses courses = new RegistrarEditCourses();
                    this.Hide();
                    courses.Closed += (s, args) => this.Show();
                    courses.Show(); break;
                case "Sections":
                    RegistrarEditSections sections = new RegistrarEditSections();
                    this.Hide();
                    sections.Closed += (s, args) => this.Show();
                    sections.Show(); break;
                case "Enrolls":
                    RegistrarEditEnrolls enrolls = new RegistrarEditEnrolls();
                    this.Hide();
                    enrolls.Closed += (s, args) => this.Show();
                    enrolls.Show(); break;
                case "Authorizations":
                    RegistrarEditAuthorizations authorizations = new RegistrarEditAuthorizations();
                    this.Hide();
                    authorizations.Closed += (s, args) => this.Show();
                    authorizations.Show(); break;
                case "Fixed Fees":
                    RegistrarEditFixedFees fixedFees = new RegistrarEditFixedFees();
                    this.Hide();
                    fixedFees.Closed += (s, args) => this.Show();
                    fixedFees.Show(); break;
                case "Variable Fee Rates":
                    RegistrarEditVariableFees variableFees = new RegistrarEditVariableFees();
                    this.Hide();
                    variableFees.Closed += (s, args) => this.Show();
                    variableFees.Show(); break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
