using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school.UI.RegistratEdit
{
    public partial class RegistrarEditCourses : Form
    {
        public RegistrarEditCourses()
        {
            InitializeComponent();
        }

        private void RegistrarEditCourses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.enquadeDataSet.courses);
            // TODO: This line of code loads data into the 'enquadeDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.enquadeDataSet.courses);

        }
    }
}
