﻿using System;
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
    public partial class RegistrarEditVariableFees : Form
    {
        public RegistrarEditVariableFees()
        {
            InitializeComponent();
        }

        private void RegistrarEditVariableFees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enquadeDataSet.variableFeeRate' table. You can move, or remove it, as needed.
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.variableFeeRateTableAdapter.Update(this.enquadeDataSet.variableFeeRate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.variableFeeRateTableAdapter.Fill(this.enquadeDataSet.variableFeeRate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
