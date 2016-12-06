namespace school.UI.RegistrarEdit
{
    partial class RegistrarEditFixedFees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquadeDataSet = new school.enquadeDataSet();
            this.fixedFeeTableAdapter = new school.enquadeDataSetTableAdapters.fixedFeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back To Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel Changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeNameDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fixedFeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 169);
            this.dataGridView1.TabIndex = 8;
            // 
            // feeNameDataGridViewTextBoxColumn
            // 
            this.feeNameDataGridViewTextBoxColumn.DataPropertyName = "feeName";
            this.feeNameDataGridViewTextBoxColumn.HeaderText = "feeName";
            this.feeNameDataGridViewTextBoxColumn.Name = "feeNameDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // fixedFeeBindingSource
            // 
            this.fixedFeeBindingSource.DataMember = "fixedFee";
            this.fixedFeeBindingSource.DataSource = this.enquadeDataSet;
            // 
            // enquadeDataSet
            // 
            this.enquadeDataSet.DataSetName = "enquadeDataSet";
            this.enquadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fixedFeeTableAdapter
            // 
            this.fixedFeeTableAdapter.ClearBeforeFill = true;
            // 
            // RegistrarEditFixedFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrarEditFixedFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarEditFixedFees";
            this.Load += new System.EventHandler(this.RegistrarEditFixedFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private enquadeDataSet enquadeDataSet;
        private System.Windows.Forms.BindingSource fixedFeeBindingSource;
        private enquadeDataSetTableAdapters.fixedFeeTableAdapter fixedFeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
    }
}