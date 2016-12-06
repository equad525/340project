namespace school.UI.RegistrarEdit
{
    partial class RegistrarEditVariableFees
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
            this.variableFeeRateTableAdapter = new school.enquadeDataSetTableAdapters.variableFeeRateTableAdapter();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOrOutOfStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorizationsTableAdapter = new school.enquadeDataSetTableAdapters.authorizationsTableAdapter();
            this.enquadeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquadeDataSet = new school.enquadeDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.authorizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.variableFeeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new school.enquadeDataSetTableAdapters.coursesTableAdapter();
            this.authorizationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // variableFeeRateTableAdapter
            // 
            this.variableFeeRateTableAdapter.ClearBeforeFill = true;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // inOrOutOfStateDataGridViewTextBoxColumn
            // 
            this.inOrOutOfStateDataGridViewTextBoxColumn.DataPropertyName = "inOrOutOfState";
            this.inOrOutOfStateDataGridViewTextBoxColumn.HeaderText = "inOrOutOfState";
            this.inOrOutOfStateDataGridViewTextBoxColumn.Name = "inOrOutOfStateDataGridViewTextBoxColumn";
            // 
            // sTypeDataGridViewTextBoxColumn
            // 
            this.sTypeDataGridViewTextBoxColumn.DataPropertyName = "sType";
            this.sTypeDataGridViewTextBoxColumn.HeaderText = "sType";
            this.sTypeDataGridViewTextBoxColumn.Name = "sTypeDataGridViewTextBoxColumn";
            // 
            // authorizationsTableAdapter
            // 
            this.authorizationsTableAdapter.ClearBeforeFill = true;
            // 
            // enquadeDataSetBindingSource
            // 
            this.enquadeDataSetBindingSource.DataSource = this.enquadeDataSet;
            this.enquadeDataSetBindingSource.Position = 0;
            // 
            // enquadeDataSet
            // 
            this.enquadeDataSet.DataSetName = "enquadeDataSet";
            this.enquadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back To Home";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel Changes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // authorizationsBindingSource
            // 
            this.authorizationsBindingSource.DataMember = "authorizations";
            this.authorizationsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // authorizationsBindingSource1
            // 
            this.authorizationsBindingSource1.DataMember = "authorizations";
            this.authorizationsBindingSource1.DataSource = this.enquadeDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTypeDataGridViewTextBoxColumn,
            this.inOrOutOfStateDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.variableFeeRateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 169);
            this.dataGridView1.TabIndex = 8;
            // 
            // variableFeeRateBindingSource
            // 
            this.variableFeeRateBindingSource.DataMember = "variableFeeRate";
            this.variableFeeRateBindingSource.DataSource = this.enquadeDataSet;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.enquadeDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // authorizationsBindingSource2
            // 
            this.authorizationsBindingSource2.DataMember = "authorizations";
            this.authorizationsBindingSource2.DataSource = this.enquadeDataSet;
            // 
            // RegistrarEditVariableFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrarEditVariableFees";
            this.Text = "RegistrarEditVariableFees";
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private enquadeDataSetTableAdapters.variableFeeRateTableAdapter variableFeeRateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOrOutOfStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTypeDataGridViewTextBoxColumn;
        private enquadeDataSetTableAdapters.authorizationsTableAdapter authorizationsTableAdapter;
        private System.Windows.Forms.BindingSource enquadeDataSetBindingSource;
        private enquadeDataSet enquadeDataSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource authorizationsBindingSource;
        private System.Windows.Forms.BindingSource authorizationsBindingSource1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource variableFeeRateBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private enquadeDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource authorizationsBindingSource2;
    }
}