namespace school
{
    partial class DepartmentStaffHome
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
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label crnLabel;
            System.Windows.Forms.Label sidLabel;
            System.Windows.Forms.Label authTypeLabel;
            System.Windows.Forms.Label sidLabel1;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label sTypeLabel;
            System.Windows.Forms.Label gradAssistantLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.enquadeDataSet = new school.enquadeDataSet();
            this.authorizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationsTableAdapter = new school.enquadeDataSetTableAdapters.authorizationsTableAdapter();
            this.tableAdapterManager = new school.enquadeDataSetTableAdapters.TableAdapterManager();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.crnTextBox = new System.Windows.Forms.TextBox();
            this.sidTextBox = new System.Windows.Forms.TextBox();
            this.authTypeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsTableAdapter = new school.enquadeDataSetTableAdapters.sectionsTableAdapter();
            this.sectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new school.enquadeDataSetTableAdapters.studentsTableAdapter();
            this.sidTextBox1 = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.sTypeTextBox = new System.Windows.Forms.TextBox();
            this.gradAssistantTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            termLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            crnLabel = new System.Windows.Forms.Label();
            sidLabel = new System.Windows.Forms.Label();
            authTypeLabel = new System.Windows.Forms.Label();
            sidLabel1 = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            sTypeLabel = new System.Windows.Forms.Label();
            gradAssistantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grant a student an authorization";
            // 
            // enquadeDataSet
            // 
            this.enquadeDataSet.DataSetName = "enquadeDataSet";
            this.enquadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorizationsBindingSource
            // 
            this.authorizationsBindingSource.DataMember = "authorizations";
            this.authorizationsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // authorizationsTableAdapter
            // 
            this.authorizationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorizationsTableAdapter = this.authorizationsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.enrollsTableAdapter = null;
            this.tableAdapterManager.fixedFeeTableAdapter = null;
            this.tableAdapterManager.sectionsTableAdapter = this.sectionsTableAdapter;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.Tb_ConsumerTableAdapter = null;
            this.tableAdapterManager.TB_OffersTableAdapter = null;
            this.tableAdapterManager.Tb_ProductTableAdapter = null;
            this.tableAdapterManager.Tb_RequestsTableAdapter = null;
            this.tableAdapterManager.Tb_SupplierTableAdapter = null;
            this.tableAdapterManager.Tb_TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = school.enquadeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.variableFeeRateTableAdapter = null;
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(12, 39);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(30, 13);
            termLabel.TabIndex = 1;
            termLabel.Text = "term:";
            // 
            // termTextBox
            // 
            this.termTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorizationsBindingSource, "term", true));
            this.termTextBox.Location = new System.Drawing.Point(76, 36);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 20);
            this.termTextBox.TabIndex = 2;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(12, 65);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(30, 13);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorizationsBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(76, 62);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 4;
            // 
            // crnLabel
            // 
            crnLabel.AutoSize = true;
            crnLabel.Location = new System.Drawing.Point(12, 91);
            crnLabel.Name = "crnLabel";
            crnLabel.Size = new System.Drawing.Size(25, 13);
            crnLabel.TabIndex = 5;
            crnLabel.Text = "crn:";
            // 
            // crnTextBox
            // 
            this.crnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorizationsBindingSource, "crn", true));
            this.crnTextBox.Location = new System.Drawing.Point(76, 88);
            this.crnTextBox.Name = "crnTextBox";
            this.crnTextBox.Size = new System.Drawing.Size(100, 20);
            this.crnTextBox.TabIndex = 6;
            // 
            // sidLabel
            // 
            sidLabel.AutoSize = true;
            sidLabel.Location = new System.Drawing.Point(12, 117);
            sidLabel.Name = "sidLabel";
            sidLabel.Size = new System.Drawing.Size(23, 13);
            sidLabel.TabIndex = 7;
            sidLabel.Text = "sid:";
            // 
            // sidTextBox
            // 
            this.sidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorizationsBindingSource, "sid", true));
            this.sidTextBox.Location = new System.Drawing.Point(76, 114);
            this.sidTextBox.Name = "sidTextBox";
            this.sidTextBox.Size = new System.Drawing.Size(100, 20);
            this.sidTextBox.TabIndex = 8;
            // 
            // authTypeLabel
            // 
            authTypeLabel.AutoSize = true;
            authTypeLabel.Location = new System.Drawing.Point(12, 143);
            authTypeLabel.Name = "authTypeLabel";
            authTypeLabel.Size = new System.Drawing.Size(58, 13);
            authTypeLabel.TabIndex = 9;
            authTypeLabel.Text = "auth Type:";
            // 
            // authTypeTextBox
            // 
            this.authTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorizationsBindingSource, "authType", true));
            this.authTypeTextBox.Location = new System.Drawing.Point(76, 140);
            this.authTypeTextBox.Name = "authTypeTextBox";
            this.authTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.authTypeTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Grant Authorization";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "sections";
            this.sectionsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // sectionsDataGridView
            // 
            this.sectionsDataGridView.AutoGenerateColumns = false;
            this.sectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.sectionsDataGridView.DataSource = this.sectionsBindingSource;
            this.sectionsDataGridView.Location = new System.Drawing.Point(12, 282);
            this.sectionsDataGridView.Name = "sectionsDataGridView";
            this.sectionsDataGridView.Size = new System.Drawing.Size(870, 220);
            this.sectionsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "term";
            this.dataGridViewTextBoxColumn1.HeaderText = "term";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn2.HeaderText = "year";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "crn";
            this.dataGridViewTextBoxColumn3.HeaderText = "crn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cprefix";
            this.dataGridViewTextBoxColumn4.HeaderText = "cprefix";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cno";
            this.dataGridViewTextBoxColumn5.HeaderText = "cno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn6.HeaderText = "section";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "days";
            this.dataGridViewTextBoxColumn7.HeaderText = "days";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "startTime";
            this.dataGridViewTextBoxColumn8.HeaderText = "startTime";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "endTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "endTime";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "room";
            this.dataGridViewTextBoxColumn10.HeaderText = "room";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cap";
            this.dataGridViewTextBoxColumn11.HeaderText = "cap";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "instructor";
            this.dataGridViewTextBoxColumn12.HeaderText = "instructor";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "auth";
            this.dataGridViewTextBoxColumn13.HeaderText = "auth";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "View instructor\'s class list";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // sidLabel1
            // 
            sidLabel1.AutoSize = true;
            sidLabel1.Location = new System.Drawing.Point(248, 36);
            sidLabel1.Name = "sidLabel1";
            sidLabel1.Size = new System.Drawing.Size(23, 13);
            sidLabel1.TabIndex = 14;
            sidLabel1.Text = "sid:";
            // 
            // sidTextBox1
            // 
            this.sidTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "sid", true));
            this.sidTextBox1.Location = new System.Drawing.Point(330, 33);
            this.sidTextBox1.Name = "sidTextBox1";
            this.sidTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sidTextBox1.TabIndex = 15;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(248, 88);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(39, 13);
            fnameLabel.TabIndex = 18;
            fnameLabel.Text = "fname:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(330, 85);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fnameTextBox.TabIndex = 19;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(248, 114);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(38, 13);
            lnameLabel.TabIndex = 20;
            lnameLabel.Text = "lname:";
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(330, 111);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lnameTextBox.TabIndex = 21;
            // 
            // sTypeLabel
            // 
            sTypeLabel.AutoSize = true;
            sTypeLabel.Location = new System.Drawing.Point(248, 63);
            sTypeLabel.Name = "sTypeLabel";
            sTypeLabel.Size = new System.Drawing.Size(42, 13);
            sTypeLabel.TabIndex = 22;
            sTypeLabel.Text = "s Type:";
            // 
            // sTypeTextBox
            // 
            this.sTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "sType", true));
            this.sTypeTextBox.Location = new System.Drawing.Point(330, 60);
            this.sTypeTextBox.Name = "sTypeTextBox";
            this.sTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTypeTextBox.TabIndex = 23;
            // 
            // gradAssistantLabel
            // 
            gradAssistantLabel.AutoSize = true;
            gradAssistantLabel.Location = new System.Drawing.Point(248, 141);
            gradAssistantLabel.Name = "gradAssistantLabel";
            gradAssistantLabel.Size = new System.Drawing.Size(76, 13);
            gradAssistantLabel.TabIndex = 26;
            gradAssistantLabel.Text = "grad Assistant:";
            // 
            // gradAssistantTextBox
            // 
            this.gradAssistantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "gradAssistant", true));
            this.gradAssistantTextBox.Location = new System.Drawing.Point(330, 138);
            this.gradAssistantTextBox.Name = "gradAssistantTextBox";
            this.gradAssistantTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradAssistantTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Add assistantship info for student";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 38);
            this.button2.TabIndex = 29;
            this.button2.Text = "Accept assistantship change";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DepartmentStaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(sidLabel1);
            this.Controls.Add(this.sidTextBox1);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(sTypeLabel);
            this.Controls.Add(this.sTypeTextBox);
            this.Controls.Add(gradAssistantLabel);
            this.Controls.Add(this.gradAssistantTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(termLabel);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(crnLabel);
            this.Controls.Add(this.crnTextBox);
            this.Controls.Add(sidLabel);
            this.Controls.Add(this.sidTextBox);
            this.Controls.Add(authTypeLabel);
            this.Controls.Add(this.authTypeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentStaffHome";
            this.Text = "Department Staff Home";
            this.Load += new System.EventHandler(this.DepartmentStaffHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private enquadeDataSet enquadeDataSet;
        private System.Windows.Forms.BindingSource authorizationsBindingSource;
        private enquadeDataSetTableAdapters.authorizationsTableAdapter authorizationsTableAdapter;
        private enquadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private enquadeDataSetTableAdapters.sectionsTableAdapter sectionsTableAdapter;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox crnTextBox;
        private System.Windows.Forms.TextBox sidTextBox;
        private System.Windows.Forms.TextBox authTypeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private enquadeDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView sectionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.TextBox sidTextBox1;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox sTypeTextBox;
        private System.Windows.Forms.TextBox gradAssistantTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}