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
    public partial class RegistrarEditStudent : Form
    {
        public RegistrarEditStudent()
        {
            InitializeComponent();
        }

        private void RegistrarEditStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
            // TODO: This line of code loads data into the 'enquadeDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.enquadeDataSet.students);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.enquadeDataSet.students);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
