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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tableToLoad = comboBox1.SelectedValue;
            //if tableToLoad.Equals()
            // check what which table was selected
            // depending on which table was selected, assign variables to be used in filder

            string filter = "Name = '" + "'";

            //depending on which table was selected, add filter to that table
            DataRow[] rows = this.enquadeDataSet.Tb_Product.Select(filter);


            RegistrarEdit editThis = new RegistrarEdit();
            // bind gridview in RegistatEdit
            editThis.dataGridView1.DataSource = rows.CopyToDataTable();
            // open RegistarEdit
            editThis.Show();
        }
    }
}
