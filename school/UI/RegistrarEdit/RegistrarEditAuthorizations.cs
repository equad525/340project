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
    public partial class RegistrarEditAuthorizations : Form
    {
        public RegistrarEditAuthorizations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.authorizations' table. You can move, or remove it, as needed.
            this.authorizationsTableAdapter.Fill(this.enquadeDataSet.authorizations);
            // TODO: This line of code loads data into the 'enquadeDataSet.authorizations' table. You can move, or remove it, as needed.
            this.authorizationsTableAdapter.Fill(this.enquadeDataSet.authorizations);

        }
    }
}
