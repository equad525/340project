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
    public partial class DepartmentStaffHome : Form
    {
        public DepartmentStaffHome()
        {
            InitializeComponent();
        }

        private void authorizationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorizationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.enquadeDataSet);

        }

        private void DepartmentStaffHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
            // TODO: This line of code loads data into the 'enquadeDataSet.sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.enquadeDataSet.sections);
            // TODO: This line of code loads data into the 'enquadeDataSet.authorizations' table. You can move, or remove it, as needed.
            this.authorizationsTableAdapter.Fill(this.enquadeDataSet.authorizations);

        }
    }
}
