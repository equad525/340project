namespace school
{
    partial class frmStudentHome
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
            System.Windows.Forms.Label crnLabel;
            System.Windows.Forms.Label sidLabel;
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquadeDataSet = new school.enquadeDataSet();
            this.staffTableAdapter = new school.enquadeDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new school.enquadeDataSetTableAdapters.TableAdapterManager();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsTableAdapter = new school.enquadeDataSetTableAdapters.sectionsTableAdapter();
            this.crnTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollsTableAdapter = new school.enquadeDataSetTableAdapters.enrollsTableAdapter();
            this.currentScheduleGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.variableFeeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variableFeeRateTableAdapter = new school.enquadeDataSetTableAdapters.variableFeeRateTableAdapter();
            this.variableFeeRateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.fixedFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixedFeeTableAdapter = new school.enquadeDataSetTableAdapters.fixedFeeTableAdapter();
            this.fixedFeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pastEnrollsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.fKenrolls24927208BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKenrolls24927208BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new school.enquadeDataSetTableAdapters.studentsTableAdapter();
            this.sidTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInOrOutOfState = new System.Windows.Forms.Label();
            this.btnVariableFeeRate = new System.Windows.Forms.Button();
            this.stypeComboBox = new System.Windows.Forms.ComboBox();
            this.residencyStatusComboBox = new System.Windows.Forms.ComboBox();
            this.variableFeeRateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.variableFeeRateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            crnLabel = new System.Windows.Forms.Label();
            sidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentScheduleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastEnrollsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKenrolls24927208BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKenrolls24927208BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // crnLabel
            // 
            crnLabel.AutoSize = true;
            crnLabel.Location = new System.Drawing.Point(12, 379);
            crnLabel.Name = "crnLabel";
            crnLabel.Size = new System.Drawing.Size(25, 13);
            crnLabel.TabIndex = 4;
            crnLabel.Text = "crn:";
            // 
            // sidLabel
            // 
            sidLabel.AutoSize = true;
            sidLabel.Location = new System.Drawing.Point(14, 231);
            sidLabel.Name = "sidLabel";
            sidLabel.Size = new System.Drawing.Size(23, 13);
            sidLabel.TabIndex = 35;
            sidLabel.Text = "sid:";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.enquadeDataSet;
            // 
            // enquadeDataSet
            // 
            this.enquadeDataSet.DataSetName = "enquadeDataSet";
            this.enquadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorizationsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.enrollsTableAdapter = null;
            this.tableAdapterManager.fixedFeeTableAdapter = null;
            this.tableAdapterManager.sectionsTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.Tb_ConsumerTableAdapter = null;
            this.tableAdapterManager.TB_OffersTableAdapter = null;
            this.tableAdapterManager.Tb_ProductTableAdapter = null;
            this.tableAdapterManager.Tb_RequestsTableAdapter = null;
            this.tableAdapterManager.Tb_SupplierTableAdapter = null;
            this.tableAdapterManager.Tb_TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = school.enquadeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.variableFeeRateTableAdapter = null;
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
            // crnTextBox
            // 
            this.crnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "crn", true));
            this.crnTextBox.Location = new System.Drawing.Point(43, 376);
            this.crnTextBox.Name = "crnTextBox";
            this.crnTextBox.Size = new System.Drawing.Size(145, 20);
            this.crnTextBox.TabIndex = 5;
            this.crnTextBox.TextChanged += new System.EventHandler(this.crnTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Register for a course section";
            // 
            // enrollsBindingSource
            // 
            this.enrollsBindingSource.DataMember = "FK__enrolls__24927208";
            this.enrollsBindingSource.DataSource = this.sectionsBindingSource;
            // 
            // enrollsTableAdapter
            // 
            this.enrollsTableAdapter.ClearBeforeFill = true;
            // 
            // currentScheduleGridView
            // 
            this.currentScheduleGridView.AllowUserToAddRows = false;
            this.currentScheduleGridView.AllowUserToDeleteRows = false;
            this.currentScheduleGridView.AutoGenerateColumns = false;
            this.currentScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentScheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.cprefix,
            this.cno,
            this.section,
            this.days,
            this.startTime,
            this.room,
            this.instructor,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.endTime});
            this.currentScheduleGridView.DataSource = this.sectionsBindingSource;
            this.currentScheduleGridView.Location = new System.Drawing.Point(12, 25);
            this.currentScheduleGridView.Name = "currentScheduleGridView";
            this.currentScheduleGridView.ReadOnly = true;
            this.currentScheduleGridView.Size = new System.Drawing.Size(873, 145);
            this.currentScheduleGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "term";
            this.dataGridViewTextBoxColumn2.HeaderText = "term";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cprefix
            // 
            this.cprefix.DataPropertyName = "cprefix";
            this.cprefix.HeaderText = "cprefix";
            this.cprefix.Name = "cprefix";
            this.cprefix.ReadOnly = true;
            // 
            // cno
            // 
            this.cno.DataPropertyName = "cno";
            this.cno.HeaderText = "cno";
            this.cno.Name = "cno";
            this.cno.ReadOnly = true;
            // 
            // section
            // 
            this.section.DataPropertyName = "section";
            this.section.HeaderText = "section";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // days
            // 
            this.days.DataPropertyName = "days";
            this.days.HeaderText = "days";
            this.days.Name = "days";
            this.days.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.HeaderText = "startTime";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "room";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // instructor
            // 
            this.instructor.DataPropertyName = "instructor";
            this.instructor.HeaderText = "instructor";
            this.instructor.Name = "instructor";
            this.instructor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn3.HeaderText = "year";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "crn";
            this.dataGridViewTextBoxColumn4.HeaderText = "crn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "endTime";
            this.endTime.HeaderText = "endTime";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "View schedule for enrolled classes";
            // 
            // variableFeeRateBindingSource
            // 
            this.variableFeeRateBindingSource.DataMember = "variableFeeRate";
            this.variableFeeRateBindingSource.DataSource = this.enquadeDataSet;
            this.variableFeeRateBindingSource.Filter = "";
            // 
            // variableFeeRateTableAdapter
            // 
            this.variableFeeRateTableAdapter.ClearBeforeFill = true;
            // 
            // variableFeeRateDataGridView
            // 
            this.variableFeeRateDataGridView.AllowUserToAddRows = false;
            this.variableFeeRateDataGridView.AllowUserToDeleteRows = false;
            this.variableFeeRateDataGridView.AutoGenerateColumns = false;
            this.variableFeeRateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variableFeeRateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.variableFeeRateDataGridView.DataSource = this.variableFeeRateBindingSource;
            this.variableFeeRateDataGridView.Location = new System.Drawing.Point(338, 487);
            this.variableFeeRateDataGridView.Name = "variableFeeRateDataGridView";
            this.variableFeeRateDataGridView.ReadOnly = true;
            this.variableFeeRateDataGridView.Size = new System.Drawing.Size(343, 133);
            this.variableFeeRateDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sType";
            this.dataGridViewTextBoxColumn6.HeaderText = "sType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "inOrOutOfState";
            this.dataGridViewTextBoxColumn7.HeaderText = "inOrOutOfState";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fee";
            this.dataGridViewTextBoxColumn8.HeaderText = "fee";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Variable fee rate";
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
            // fixedFeeDataGridView
            // 
            this.fixedFeeDataGridView.AllowUserToAddRows = false;
            this.fixedFeeDataGridView.AllowUserToDeleteRows = false;
            this.fixedFeeDataGridView.AutoGenerateColumns = false;
            this.fixedFeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fixedFeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.fixedFeeDataGridView.DataSource = this.fixedFeeBindingSource;
            this.fixedFeeDataGridView.Location = new System.Drawing.Point(12, 487);
            this.fixedFeeDataGridView.Name = "fixedFeeDataGridView";
            this.fixedFeeDataGridView.ReadOnly = true;
            this.fixedFeeDataGridView.Size = new System.Drawing.Size(243, 133);
            this.fixedFeeDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "feeName";
            this.dataGridViewTextBoxColumn9.HeaderText = "feeName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fee";
            this.dataGridViewTextBoxColumn10.HeaderText = "fee";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fixed fees";
            // 
            // pastEnrollsGridView
            // 
            this.pastEnrollsGridView.AllowUserToAddRows = false;
            this.pastEnrollsGridView.AllowUserToDeleteRows = false;
            this.pastEnrollsGridView.AutoGenerateColumns = false;
            this.pastEnrollsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastEnrollsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.pastEnrollsGridView.DataSource = this.enrollsBindingSource1;
            this.pastEnrollsGridView.Location = new System.Drawing.Point(341, 210);
            this.pastEnrollsGridView.Name = "pastEnrollsGridView";
            this.pastEnrollsGridView.ReadOnly = true;
            this.pastEnrollsGridView.Size = new System.Drawing.Size(544, 241);
            this.pastEnrollsGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "sid";
            this.dataGridViewTextBoxColumn11.HeaderText = "sid";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "term";
            this.dataGridViewTextBoxColumn12.HeaderText = "term";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn13.HeaderText = "year";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "crn";
            this.dataGridViewTextBoxColumn14.HeaderText = "crn";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn15.HeaderText = "grade";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // enrollsBindingSource1
            // 
            this.enrollsBindingSource1.DataMember = "enrolls";
            this.enrollsBindingSource1.DataSource = this.enquadeDataSet;
            this.enrollsBindingSource1.Filter = "";
            this.enrollsBindingSource1.DataMemberChanged += new System.EventHandler(this.btnVariableFeeRate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "View transcripts from past enrollments";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 413);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 38);
            this.btnRegister.TabIndex = 35;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // fKenrolls24927208BindingSource
            // 
            this.fKenrolls24927208BindingSource.DataMember = "FK__enrolls__24927208";
            this.fKenrolls24927208BindingSource.DataSource = this.sectionsBindingSource;
            // 
            // fKenrolls24927208BindingSource1
            // 
            this.fKenrolls24927208BindingSource1.DataMember = "FK__enrolls__24927208";
            this.fKenrolls24927208BindingSource1.DataSource = this.sectionsBindingSource;
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
            // sidTextBox
            // 
            this.sidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "sid", true));
            this.sidTextBox.Location = new System.Drawing.Point(43, 228);
            this.sidTextBox.Name = "sidTextBox";
            this.sidTextBox.Size = new System.Drawing.Size(145, 20);
            this.sidTextBox.TabIndex = 36;
            this.sidTextBox.TextChanged += new System.EventHandler(this.sidTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Enter your student ID number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Enter the crn to register for";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Enter term";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "term:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Enter year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "year";
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(44, 280);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 20);
            this.termTextBox.TabIndex = 43;
            this.termTextBox.TextChanged += new System.EventHandler(this.termTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(43, 334);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 44;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(738, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Type of student";
            // 
            // lblInOrOutOfState
            // 
            this.lblInOrOutOfState.AutoSize = true;
            this.lblInOrOutOfState.Location = new System.Drawing.Point(741, 533);
            this.lblInOrOutOfState.Name = "lblInOrOutOfState";
            this.lblInOrOutOfState.Size = new System.Drawing.Size(88, 13);
            this.lblInOrOutOfState.TabIndex = 47;
            this.lblInOrOutOfState.Text = "Residency status";
            // 
            // btnVariableFeeRate
            // 
            this.btnVariableFeeRate.Location = new System.Drawing.Point(741, 585);
            this.btnVariableFeeRate.Name = "btnVariableFeeRate";
            this.btnVariableFeeRate.Size = new System.Drawing.Size(121, 40);
            this.btnVariableFeeRate.TabIndex = 51;
            this.btnVariableFeeRate.Text = "Show variable fees";
            this.btnVariableFeeRate.UseVisualStyleBackColor = true;
            this.btnVariableFeeRate.Click += new System.EventHandler(this.btnVariableFeeRate_Click);
            // 
            // stypeComboBox
            // 
            this.stypeComboBox.DataSource = this.variableFeeRateBindingSource1;
            this.stypeComboBox.DisplayMember = "sType";
            this.stypeComboBox.FormattingEnabled = true;
            this.stypeComboBox.Location = new System.Drawing.Point(741, 504);
            this.stypeComboBox.Name = "stypeComboBox";
            this.stypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.stypeComboBox.TabIndex = 52;
            // 
            // residencyStatusComboBox
            // 
            this.residencyStatusComboBox.DataSource = this.variableFeeRateBindingSource2;
            this.residencyStatusComboBox.DisplayMember = "inOrOutOfState";
            this.residencyStatusComboBox.FormattingEnabled = true;
            this.residencyStatusComboBox.Location = new System.Drawing.Point(741, 550);
            this.residencyStatusComboBox.Name = "residencyStatusComboBox";
            this.residencyStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.residencyStatusComboBox.TabIndex = 53;
            // 
            // variableFeeRateBindingSource1
            // 
            this.variableFeeRateBindingSource1.DataMember = "variableFeeRate";
            this.variableFeeRateBindingSource1.DataSource = this.enquadeDataSet;
            // 
            // variableFeeRateBindingSource2
            // 
            this.variableFeeRateBindingSource2.DataMember = "variableFeeRate";
            this.variableFeeRateBindingSource2.DataSource = this.enquadeDataSet;
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 640);
            this.Controls.Add(this.residencyStatusComboBox);
            this.Controls.Add(this.stypeComboBox);
            this.Controls.Add(this.btnVariableFeeRate);
            this.Controls.Add(this.lblInOrOutOfState);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(sidLabel);
            this.Controls.Add(this.sidTextBox);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pastEnrollsGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fixedFeeDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.variableFeeRateDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentScheduleGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(crnLabel);
            this.Controls.Add(this.crnTextBox);
            this.Name = "frmStudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Home";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentScheduleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastEnrollsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKenrolls24927208BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKenrolls24927208BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private enquadeDataSet enquadeDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private enquadeDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private enquadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private enquadeDataSetTableAdapters.sectionsTableAdapter sectionsTableAdapter;
        private System.Windows.Forms.TextBox crnTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource enrollsBindingSource;
        private enquadeDataSetTableAdapters.enrollsTableAdapter enrollsTableAdapter;
        private System.Windows.Forms.DataGridView currentScheduleGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource variableFeeRateBindingSource;
        private enquadeDataSetTableAdapters.variableFeeRateTableAdapter variableFeeRateTableAdapter;
        private System.Windows.Forms.DataGridView variableFeeRateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fixedFeeBindingSource;
        private enquadeDataSetTableAdapters.fixedFeeTableAdapter fixedFeeTableAdapter;
        private System.Windows.Forms.DataGridView fixedFeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView pastEnrollsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn cno;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.BindingSource fKenrolls24927208BindingSource;
        private System.Windows.Forms.BindingSource fKenrolls24927208BindingSource1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private enquadeDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.TextBox sidTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource enrollsBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInOrOutOfState;
        private System.Windows.Forms.Button btnVariableFeeRate;
        private System.Windows.Forms.ComboBox stypeComboBox;
        private System.Windows.Forms.ComboBox residencyStatusComboBox;
        private System.Windows.Forms.BindingSource variableFeeRateBindingSource1;
        private System.Windows.Forms.BindingSource variableFeeRateBindingSource2;
    }
}

