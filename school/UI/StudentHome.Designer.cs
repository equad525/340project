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
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label crnLabel;
            System.Windows.Forms.Label cprefixLabel;
            System.Windows.Forms.Label cnoLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label daysLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label roomLabel;
            System.Windows.Forms.Label capLabel;
            System.Windows.Forms.Label instructorLabel;
            System.Windows.Forms.Label authLabel;
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquadeDataSet = new school.enquadeDataSet();
            this.staffTableAdapter = new school.enquadeDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new school.enquadeDataSetTableAdapters.TableAdapterManager();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsTableAdapter = new school.enquadeDataSetTableAdapters.sectionsTableAdapter();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.crnTextBox = new System.Windows.Forms.TextBox();
            this.cprefixTextBox = new System.Windows.Forms.TextBox();
            this.cnoTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.capTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            this.authTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollsTableAdapter = new school.enquadeDataSetTableAdapters.enrollsTableAdapter();
            this.currentEnrollsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            termLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            crnLabel = new System.Windows.Forms.Label();
            cprefixLabel = new System.Windows.Forms.Label();
            cnoLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            daysLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            capLabel = new System.Windows.Forms.Label();
            instructorLabel = new System.Windows.Forms.Label();
            authLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEnrollsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastEnrollsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(12, 28);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(30, 13);
            termLabel.TabIndex = 0;
            termLabel.Text = "term:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(12, 54);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(30, 13);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "year:";
            // 
            // crnLabel
            // 
            crnLabel.AutoSize = true;
            crnLabel.Location = new System.Drawing.Point(12, 80);
            crnLabel.Name = "crnLabel";
            crnLabel.Size = new System.Drawing.Size(25, 13);
            crnLabel.TabIndex = 4;
            crnLabel.Text = "crn:";
            // 
            // cprefixLabel
            // 
            cprefixLabel.AutoSize = true;
            cprefixLabel.Location = new System.Drawing.Point(12, 106);
            cprefixLabel.Name = "cprefixLabel";
            cprefixLabel.Size = new System.Drawing.Size(41, 13);
            cprefixLabel.TabIndex = 6;
            cprefixLabel.Text = "cprefix:";
            // 
            // cnoLabel
            // 
            cnoLabel.AutoSize = true;
            cnoLabel.Location = new System.Drawing.Point(12, 132);
            cnoLabel.Name = "cnoLabel";
            cnoLabel.Size = new System.Drawing.Size(28, 13);
            cnoLabel.TabIndex = 8;
            cnoLabel.Text = "cno:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(12, 158);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(44, 13);
            sectionLabel.TabIndex = 10;
            sectionLabel.Text = "section:";
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Location = new System.Drawing.Point(12, 184);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new System.Drawing.Size(32, 13);
            daysLabel.TabIndex = 12;
            daysLabel.Text = "days:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(12, 210);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(56, 13);
            startTimeLabel.TabIndex = 14;
            startTimeLabel.Text = "start Time:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(12, 236);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(54, 13);
            endTimeLabel.TabIndex = 16;
            endTimeLabel.Text = "end Time:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(12, 262);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(33, 13);
            roomLabel.TabIndex = 18;
            roomLabel.Text = "room:";
            // 
            // capLabel
            // 
            capLabel.AutoSize = true;
            capLabel.Location = new System.Drawing.Point(12, 288);
            capLabel.Name = "capLabel";
            capLabel.Size = new System.Drawing.Size(28, 13);
            capLabel.TabIndex = 20;
            capLabel.Text = "cap:";
            // 
            // instructorLabel
            // 
            instructorLabel.AutoSize = true;
            instructorLabel.Location = new System.Drawing.Point(12, 314);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new System.Drawing.Size(53, 13);
            instructorLabel.TabIndex = 22;
            instructorLabel.Text = "instructor:";
            // 
            // authLabel
            // 
            authLabel.AutoSize = true;
            authLabel.Location = new System.Drawing.Point(12, 340);
            authLabel.Name = "authLabel";
            authLabel.Size = new System.Drawing.Size(31, 13);
            authLabel.TabIndex = 24;
            authLabel.Text = "auth:";
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
            // termTextBox
            // 
            this.termTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "term", true));
            this.termTextBox.Location = new System.Drawing.Point(74, 25);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 20);
            this.termTextBox.TabIndex = 1;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(74, 51);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // crnTextBox
            // 
            this.crnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "crn", true));
            this.crnTextBox.Location = new System.Drawing.Point(74, 77);
            this.crnTextBox.Name = "crnTextBox";
            this.crnTextBox.Size = new System.Drawing.Size(100, 20);
            this.crnTextBox.TabIndex = 5;
            // 
            // cprefixTextBox
            // 
            this.cprefixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "cprefix", true));
            this.cprefixTextBox.Location = new System.Drawing.Point(74, 103);
            this.cprefixTextBox.Name = "cprefixTextBox";
            this.cprefixTextBox.Size = new System.Drawing.Size(100, 20);
            this.cprefixTextBox.TabIndex = 7;
            // 
            // cnoTextBox
            // 
            this.cnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "cno", true));
            this.cnoTextBox.Location = new System.Drawing.Point(74, 129);
            this.cnoTextBox.Name = "cnoTextBox";
            this.cnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnoTextBox.TabIndex = 9;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(74, 155);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 11;
            // 
            // daysTextBox
            // 
            this.daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "days", true));
            this.daysTextBox.Location = new System.Drawing.Point(74, 181);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 13;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "startTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(74, 207);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTimeTextBox.TabIndex = 15;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "endTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(74, 233);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTimeTextBox.TabIndex = 17;
            // 
            // roomTextBox
            // 
            this.roomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "room", true));
            this.roomTextBox.Location = new System.Drawing.Point(74, 259);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomTextBox.TabIndex = 19;
            // 
            // capTextBox
            // 
            this.capTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "cap", true));
            this.capTextBox.Location = new System.Drawing.Point(74, 285);
            this.capTextBox.Name = "capTextBox";
            this.capTextBox.Size = new System.Drawing.Size(100, 20);
            this.capTextBox.TabIndex = 21;
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "instructor", true));
            this.instructorTextBox.Location = new System.Drawing.Point(74, 311);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.Size = new System.Drawing.Size(100, 20);
            this.instructorTextBox.TabIndex = 23;
            // 
            // authTextBox
            // 
            this.authTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "auth", true));
            this.authTextBox.Location = new System.Drawing.Point(74, 337);
            this.authTextBox.Name = "authTextBox";
            this.authTextBox.Size = new System.Drawing.Size(100, 20);
            this.authTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            // currentEnrollsGridView
            // 
            this.currentEnrollsGridView.AutoGenerateColumns = false;
            this.currentEnrollsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentEnrollsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.currentEnrollsGridView.DataSource = this.enrollsBindingSource;
            this.currentEnrollsGridView.Location = new System.Drawing.Point(338, 25);
            this.currentEnrollsGridView.Name = "currentEnrollsGridView";
            this.currentEnrollsGridView.Size = new System.Drawing.Size(547, 145);
            this.currentEnrollsGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sid";
            this.dataGridViewTextBoxColumn1.HeaderText = "sid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "term";
            this.dataGridViewTextBoxColumn2.HeaderText = "term";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn5.HeaderText = "grade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 6);
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
            this.variableFeeRateDataGridView.AutoGenerateColumns = false;
            this.variableFeeRateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variableFeeRateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.variableFeeRateDataGridView.DataSource = this.variableFeeRateBindingSource;
            this.variableFeeRateDataGridView.Location = new System.Drawing.Point(338, 487);
            this.variableFeeRateDataGridView.Name = "variableFeeRateDataGridView";
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
            this.fixedFeeDataGridView.AutoGenerateColumns = false;
            this.fixedFeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fixedFeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.fixedFeeDataGridView.DataSource = this.fixedFeeBindingSource;
            this.fixedFeeDataGridView.Location = new System.Drawing.Point(12, 487);
            this.fixedFeeDataGridView.Name = "fixedFeeDataGridView";
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
            this.pastEnrollsGridView.AutoGenerateColumns = false;
            this.pastEnrollsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastEnrollsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.pastEnrollsGridView.DataSource = this.enrollsBindingSource;
            this.pastEnrollsGridView.Location = new System.Drawing.Point(341, 210);
            this.pastEnrollsGridView.Name = "pastEnrollsGridView";
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
            this.btnRegister.Location = new System.Drawing.Point(13, 373);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 45);
            this.btnRegister.TabIndex = 35;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 633);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pastEnrollsGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fixedFeeDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.variableFeeRateDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentEnrollsGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(termLabel);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(crnLabel);
            this.Controls.Add(this.crnTextBox);
            this.Controls.Add(cprefixLabel);
            this.Controls.Add(this.cprefixTextBox);
            this.Controls.Add(cnoLabel);
            this.Controls.Add(this.cnoTextBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(daysLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(roomLabel);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(capLabel);
            this.Controls.Add(this.capTextBox);
            this.Controls.Add(instructorLabel);
            this.Controls.Add(this.instructorTextBox);
            this.Controls.Add(authLabel);
            this.Controls.Add(this.authTextBox);
            this.Name = "frmStudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Home";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEnrollsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableFeeRateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedFeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastEnrollsGridView)).EndInit();
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
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox crnTextBox;
        private System.Windows.Forms.TextBox cprefixTextBox;
        private System.Windows.Forms.TextBox cnoTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox capTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.TextBox authTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource enrollsBindingSource;
        private enquadeDataSetTableAdapters.enrollsTableAdapter enrollsTableAdapter;
        private System.Windows.Forms.DataGridView currentEnrollsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
    }
}

