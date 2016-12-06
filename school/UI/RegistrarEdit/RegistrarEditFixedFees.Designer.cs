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
            this.authorizationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.enquadeDataSet = new school.enquadeDataSet();
            this.coursesTableAdapter = new school.enquadeDataSetTableAdapters.coursesTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.enquadeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationsTableAdapter = new school.enquadeDataSetTableAdapters.authorizationsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixedFeeTableAdapter = new school.enquadeDataSetTableAdapters.fixedFeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationsBindingSource2
            // 
            this.authorizationsBindingSource2.DataMember = "authorizations";
            this.authorizationsBindingSource2.DataSource = this.enquadeDataSet;
            // 
            // enquadeDataSet
            // 
            this.enquadeDataSet.DataSetName = "enquadeDataSet";
            this.enquadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.enquadeDataSet;
            // 
            // authorizationsBindingSource1
            // 
            this.authorizationsBindingSource1.DataMember = "authorizations";
            this.authorizationsBindingSource1.DataSource = this.enquadeDataSet;
            // 
            // authorizationsBindingSource
            // 
            this.authorizationsBindingSource.DataMember = "authorizations";
            this.authorizationsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back To Home";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel Changes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // enquadeDataSetBindingSource
            // 
            this.enquadeDataSetBindingSource.DataSource = this.enquadeDataSet;
            this.enquadeDataSetBindingSource.Position = 0;
            // 
            // authorizationsTableAdapter
            // 
            this.authorizationsTableAdapter.ClearBeforeFill = true;
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
            this.Text = "RegistrarEditFixedFees";
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource authorizationsBindingSource2;
        private enquadeDataSet enquadeDataSet;
        private enquadeDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.BindingSource authorizationsBindingSource1;
        private System.Windows.Forms.BindingSource authorizationsBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource enquadeDataSetBindingSource;
        private enquadeDataSetTableAdapters.authorizationsTableAdapter authorizationsTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fixedFeeBindingSource;
        private enquadeDataSetTableAdapters.fixedFeeTableAdapter fixedFeeTableAdapter;
    }
}