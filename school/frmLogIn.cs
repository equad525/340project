using CourseProject.PD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.UI
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                string trylogin = Main.TryLogin(txtPassword.Text,txtUsername.Text);
                if (trylogin.Equals("RegistrarStaff"))
                {
                    this.Hide();
                    frmRegistrarStaffHome regStaffForm = new frmRegistrarStaffHome();
                    regStaffForm.Show();
                    regStaffForm.Closed += (s, args) => this.Show();
                    clearLoginForm();
                }
                else if (trylogin.Equals("DepartmentStaff"))
                {
                    this.Hide();
                    frmDepartmentStaffHome deptStaffForm = new frmDepartmentStaffHome();
                    deptStaffForm.Show();
                    deptStaffForm.Closed += (s, args) => this.Show();
                    clearLoginForm();
                }
                else if (trylogin.Equals("Student"))
                {
                    this.Hide();
                    frmStudentHome studentForm = new frmStudentHome();
                    studentForm.Show();
                    studentForm.Closed += (s, args) => this.Show();
                    clearLoginForm();
                }
                else
                    MessageBox.Show("Incorrect Username or Password");
            }
        }

        private bool isValid()
        {
            return
                Validator.IsPresent(txtUsername) &&
                Validator.IsPresent(txtPassword);
        }
        private void clearLoginForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
