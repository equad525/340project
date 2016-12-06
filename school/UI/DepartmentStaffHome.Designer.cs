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
            this.enquadeDataSet = new school.enquadeDataSet();
            this.authorizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationsTableAdapter = new school.enquadeDataSetTableAdapters.authorizationsTableAdapter();
            this.tableAdapterManager = new school.enquadeDataSetTableAdapters.TableAdapterManager();
            this.sectionsTableAdapter = new school.enquadeDataSetTableAdapters.sectionsTableAdapter();
            this.studentsTableAdapter = new school.enquadeDataSetTableAdapters.studentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorSectionsView = new System.Windows.Forms.DataGridView();
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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.standardAuth = new System.Windows.Forms.RadioButton();
            this.overflowAuth = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gradAssistantGridView = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.enquadeDataSet1 = new school.enquadeDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new school.enquadeDataSetTableAdapters.staffTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorSectionsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradAssistantGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Grant Authorization";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GrantAuth_Click);
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "sections";
            this.sectionsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // instructorSectionsView
            // 
            this.instructorSectionsView.AutoGenerateColumns = false;
            this.instructorSectionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorSectionsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.instructorSectionsView.DataSource = this.sectionsBindingSource;
            this.instructorSectionsView.Location = new System.Drawing.Point(203, 325);
            this.instructorSectionsView.Name = "instructorSectionsView";
            this.instructorSectionsView.Size = new System.Drawing.Size(687, 234);
            this.instructorSectionsView.TabIndex = 12;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "View instructor\'s class list";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.enquadeDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Add assistantship info for student";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 38);
            this.button2.TabIndex = 29;
            this.button2.Text = "Accept assistantship change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddAssistantshipInfo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentsBindingSource;
            this.comboBox1.DisplayMember = "fname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sectionsBindingSource;
            this.comboBox2.DisplayMember = "cprefix";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // standardAuth
            // 
            this.standardAuth.AutoSize = true;
            this.standardAuth.Checked = true;
            this.standardAuth.Location = new System.Drawing.Point(12, 133);
            this.standardAuth.Name = "standardAuth";
            this.standardAuth.Size = new System.Drawing.Size(132, 17);
            this.standardAuth.TabIndex = 32;
            this.standardAuth.TabStop = true;
            this.standardAuth.Text = "Standard Authorization";
            this.standardAuth.UseVisualStyleBackColor = true;
            // 
            // overflowAuth
            // 
            this.overflowAuth.AutoSize = true;
            this.overflowAuth.Location = new System.Drawing.Point(12, 156);
            this.overflowAuth.Name = "overflowAuth";
            this.overflowAuth.Size = new System.Drawing.Size(67, 17);
            this.overflowAuth.TabIndex = 33;
            this.overflowAuth.Text = "Overflow";
            this.overflowAuth.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Student";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.studentsBindingSource;
            this.comboBox3.DisplayMember = "fname";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(254, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Student";
            // 
            // gradAssistantGridView
            // 
            this.gradAssistantGridView.AllowUserToAddRows = false;
            this.gradAssistantGridView.AllowUserToDeleteRows = false;
            this.gradAssistantGridView.AutoGenerateColumns = false;
            this.gradAssistantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradAssistantGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.sTypeDataGridViewTextBoxColumn});
            this.gradAssistantGridView.DataSource = this.studentsBindingSource;
            this.gradAssistantGridView.Location = new System.Drawing.Point(254, 156);
            this.gradAssistantGridView.Name = "gradAssistantGridView";
            this.gradAssistantGridView.ReadOnly = true;
            this.gradAssistantGridView.Size = new System.Drawing.Size(240, 120);
            this.gradAssistantGridView.TabIndex = 38;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTypeDataGridViewTextBoxColumn
            // 
            this.sTypeDataGridViewTextBoxColumn.DataPropertyName = "sType";
            this.sTypeDataGridViewTextBoxColumn.HeaderText = "sType";
            this.sTypeDataGridViewTextBoxColumn.Name = "sTypeDataGridViewTextBoxColumn";
            this.sTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Current Grad Assistants";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.sectionsBindingSource;
            this.comboBox4.DisplayMember = "instructor";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 370);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(149, 21);
            this.comboBox4.TabIndex = 41;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Instructor";
            // 
            // enquadeDataSet1
            // 
            this.enquadeDataSet1.DataSetName = "enquadeDataSet";
            this.enquadeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.enquadeDataSet1;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grant a student an authorization";
            // 
            // DepartmentStaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 571);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gradAssistantGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.overflowAuth);
            this.Controls.Add(this.standardAuth);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructorSectionsView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentStaffHome";
            this.Text = "Department Staff Home";
            this.Load += new System.EventHandler(this.DepartmentStaffHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorSectionsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradAssistantGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private enquadeDataSet enquadeDataSet;
        private System.Windows.Forms.BindingSource authorizationsBindingSource;
        private enquadeDataSetTableAdapters.authorizationsTableAdapter authorizationsTableAdapter;
        private enquadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private enquadeDataSetTableAdapters.sectionsTableAdapter sectionsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private enquadeDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView instructorSectionsView;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton standardAuth;
        private System.Windows.Forms.RadioButton overflowAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gradAssistantGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private enquadeDataSet enquadeDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private enquadeDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}