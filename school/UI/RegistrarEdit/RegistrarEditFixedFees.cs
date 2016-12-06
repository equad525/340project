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
    public partial class RegistrarEditFixedFees : Form
    {
        public RegistrarEditFixedFees()
        {
            InitializeComponent();
        }

        private void RegistrarEditFixedFees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.fixedFee' table. You can move, or remove it, as needed.
            this.fixedFeeTableAdapter.Fill(this.enquadeDataSet.fixedFee);

        }
    }
}
