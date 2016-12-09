using CourseProject.PD;
using Data;
using Model;
using schoolWorkVer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Data.DataAccess;

namespace school
{
    public partial class DepartmentStaffHome : Form
    {
        private Staff _user;

        public DepartmentStaffHome(string tid)
        {
            InitializeComponent();
            _user = Retrieve<Staff>(new List<Condition>()
            {
                new Condition()
                {
                    ConditionOperator = Condition.Operators.Equal,
                    Left = "tid",
                    Right = tid
                }
            })[0];

            this.Text += " - Logged in as " + _user.Fname + " " + _user.Lname;
        }

        private void authorizationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorizationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.enquadeDataSet);

        }

        private void DepartmentStaffHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet1.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.enquadeDataSet1.staff);
            // TODO: This line of code loads data into the 'enquadeDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.authorizations' table. You can move, or remove it, as needed.
            this.authorizationsTableAdapter.Fill(this.enquadeDataSet.authorizations);

            DataTable testDistinct = new DataView(enquadeDataSet.sections).ToTable(true, "instructor");
            comboBox4.DataSource = testDistinct;

            DataTable gradAssistants = new DataView(enquadeDataSet.students).ToTable(true, "sid", "fname", "lname", "sType", "gradAssistant");
            gradAssistantGridView.DataSource = gradAssistants.Select("gradAssistant='Y'").CopyToDataTable();
            
        }

        private void GrantAuth_Click(object sender, EventArgs e)
        {
            DataRow studentData = ((DataRowView)authStudentComboBox.SelectedItem).Row;
            DataRow sectionData = ((DataRowView)authSectionComboBox.SelectedItem).Row;

            string authtype = standardAuth.Checked ? "AUTH" : "OVFL";

            Authorizations newAuth = new Authorizations()
            {
                Sid = studentData.Field<short>("sid"),
                Crn = sectionData.Field<int>("crn"),
                Term = sectionData.Field<string>("term"),
                Year = sectionData.Field<short>("year"),
                AuthType = authtype
            };

            List<Authorizations> auth = DataAccess.Retrieve<Authorizations>(new ConditionList()
            {
                Conditions = new List<Condition>()
                {
                    new Condition("sid", Condition.Operators.Equal, newAuth.Sid.ToString()),
                    new Condition("crn", Condition.Operators.Equal, newAuth.Crn.ToString()),
                    new Condition("term", Condition.Operators.Equal, newAuth.Term),
                    new Condition("year", Condition.Operators.Equal, newAuth.Year.ToString()),
                    new Condition("authType", Condition.Operators.Equal, authtype)
                }
            });

            if(auth.Count <= 0)
            {
                ClearErrors();
                if (Create<Authorizations>(newAuth))
                {
                    MessageBox.Show(studentData.Field<string>("fname") + " " + studentData.Field<string>("lname") +
                        " successfully authorized for " + sectionData.Field<string>("cprefix") + sectionData.Field<Int16>("cno").ToString(),
                        null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(LastError);
                }
            }
            else
            {
                MessageBox.Show("This student is already authorized for this section.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAssistantshipInfo_Click(object sender, EventArgs e)
        {
            DataRow studentData = ((DataRowView)gradStudentComboBox.SelectedItem).Row;

            Students newStu = new Students()
            {
                Sid = studentData.Field<short>("sid"),
                GradAssistant = "Y"
            };

            List<Students> stus = DataAccess.Retrieve<Students>(new ConditionList()
            {
                Conditions = new List<Condition>()
                {
                    new Condition("sid", Condition.Operators.Equal, newStu.Sid.ToString()),
                    new Condition("gradAssistant", Condition.Operators.Equal, "Y")
                }
            });

            if(stus.Count <= 0)
            {
                ClearErrors();
                if (Update<Students>(newStu, null, new ConditionList()
                    {
                        Conditions = new List<Condition>()
                    {
                        new Condition("sid", Condition.Operators.Equal, newStu.Sid.ToString())
                    }
                    }, new string[] { "GradAssistant" })
                )
                {
                    MessageBox.Show(studentData.Field<string>("fname") + " " + studentData.Field<string>("lname") +
                        " is now a Grad Assistant",
                        null, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
                    DataTable gradAssistants = new DataView(enquadeDataSet.students).ToTable(true, "sid", "fname", "lname", "sType", "gradAssistant");
                    gradAssistantGridView.DataSource = gradAssistants.Select("gradAssistant='Y'").CopyToDataTable();
                }
                else
                {
                    MessageBox.Show(LastError);
                }
            }
            else
            {
                MessageBox.Show("This student is already a Grad Assistant", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            instructorSectionsView.DataSource = this.enquadeDataSet.sections.Select("instructor='" + ((DataRowView)comboBox4.SelectedItem).Row.Field<string>("instructor") + "'");
        }

        private void authStudentComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string fname = ((DataRowView)e.ListItem).Row.Field<string>("fname");
            string lname = ((DataRowView)e.ListItem).Row.Field<string>("lname");

            e.Value = fname + " " + lname;
        }

        private void authSectionComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string pre = ((DataRowView)e.ListItem).Row.Field<string>("cprefix");
            string crn = ((DataRowView)e.ListItem).Row.Field<int>("crn").ToString();

            e.Value = pre + crn;
        }

        private void gradStudentComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string fname = ((DataRowView)e.ListItem).Row.Field<string>("fname");
            string lname = ((DataRowView)e.ListItem).Row.Field<string>("lname");

            e.Value = fname + " " + lname;
        }
    }
}
