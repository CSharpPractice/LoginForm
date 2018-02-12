namespace LoginForm
{
    partial class frmSearchAdmin
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxSrch = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBxSrch = new System.Windows.Forms.ComboBox();
            this.btnSrch = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.lblProcessCateg = new System.Windows.Forms.Label();
            this.grpBoxProcessData = new System.Windows.Forms.GroupBox();
            this.grpBoxFixRepairList = new System.Windows.Forms.GroupBox();
            this.lblRepairLstTableFail = new System.Windows.Forms.Label();
            this.lblRepairLstFullInteg = new System.Windows.Forms.Label();
            this.lblRepairLstICS2 = new System.Windows.Forms.Label();
            this.lblRepairLstICS1 = new System.Windows.Forms.Label();
            this.lblRepairLstATS2 = new System.Windows.Forms.Label();
            this.lblRepairATS1 = new System.Windows.Forms.Label();
            this.lblRepairLstPartialInteg = new System.Windows.Forms.Label();
            this.lblRepairLstTuning = new System.Windows.Forms.Label();
            this.lblRepairLstSoldering = new System.Windows.Forms.Label();
            this.lblBurningTime = new System.Windows.Forms.Label();
            this.btnFail = new System.Windows.Forms.Button();
            this.btnTestPass = new System.Windows.Forms.Button();
            this.btnProcessDataReset = new System.Windows.Forms.Button();
            this.btnProcessDataInput = new System.Windows.Forms.Button();
            this.dateTimePickerProductionDate = new System.Windows.Forms.DateTimePicker();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.txtBxCartonBoxDCMSerial = new System.Windows.Forms.TextBox();
            this.lblCartonBxDCMSerial = new System.Windows.Forms.Label();
            this.txtBxGiftBxSerial = new System.Windows.Forms.TextBox();
            this.lblGiftBoxSerial = new System.Windows.Forms.Label();
            this.txtBxDCMSerial = new System.Windows.Forms.TextBox();
            this.lblDCMSerial = new System.Windows.Forms.Label();
            this.cmbTestItems = new System.Windows.Forms.ComboBox();
            this.lblTestItem = new System.Windows.Forms.Label();
            this.cmbBurningYesNo = new System.Windows.Forms.ComboBox();
            this.lblBurningYesNo = new System.Windows.Forms.Label();
            this.txtBxSerialNo = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.cmbErrorCategory = new System.Windows.Forms.ComboBox();
            this.lblErrorClassification = new System.Windows.Forms.Label();
            this.dTPickerBurnStop = new System.Windows.Forms.DateTimePicker();
            this.dTPickerBurnStat = new System.Windows.Forms.DateTimePicker();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtBxDetails = new System.Windows.Forms.TextBox();
            this.cmbPathSelection = new System.Windows.Forms.ComboBox();
            this.lblPointOfError = new System.Windows.Forms.Label();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.grpSerialMatching = new System.Windows.Forms.GroupBox();
            this.btnShippingDataReset = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.btnShippingDataInput = new System.Windows.Forms.Button();
            this.txtBxProductionInputDCMSerialNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblProductionDataDCMSerialNo = new System.Windows.Forms.Label();
            this.txtBxProductAdapterSerialNo = new System.Windows.Forms.TextBox();
            this.lblProductAdapterSerialNo = new System.Windows.Forms.Label();
            this.txtBxProductModemSerialNo = new System.Windows.Forms.TextBox();
            this.lblProductionModemSerialNo = new System.Windows.Forms.Label();
            this.txtBxProductCSSerialNo = new System.Windows.Forms.TextBox();
            this.lblProductCSserialNo = new System.Windows.Forms.Label();
            this.cmbProductionDataSelection = new System.Windows.Forms.ComboBox();
            this.lblProductDataTypeSelection = new System.Windows.Forms.Label();
            this.grpBoxDataSearch = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxProcessData.SuspendLayout();
            this.grpBoxFixRepairList.SuspendLayout();
            this.grpSerialMatching.SuspendLayout();
            this.grpBoxDataSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Search :";
            // 
            // txtBxSrch
            // 
            this.txtBxSrch.Location = new System.Drawing.Point(356, 45);
            this.txtBxSrch.Name = "txtBxSrch";
            this.txtBxSrch.Size = new System.Drawing.Size(142, 25);
            this.txtBxSrch.TabIndex = 23;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LoginForm.BizContacts);
            // 
            // cmbBxSrch
            // 
            this.cmbBxSrch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBxSrch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSrch.FormattingEnabled = true;
            this.cmbBxSrch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Company"});
            this.cmbBxSrch.Location = new System.Drawing.Point(143, 45);
            this.cmbBxSrch.Name = "cmbBxSrch";
            this.cmbBxSrch.Size = new System.Drawing.Size(121, 23);
            this.cmbBxSrch.TabIndex = 25;
            // 
            // btnSrch
            // 
            this.btnSrch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSrch.Location = new System.Drawing.Point(514, 46);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(75, 23);
            this.btnSrch.TabIndex = 26;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdt.Location = new System.Drawing.Point(609, 46);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(75, 23);
            this.btnEdt.TabIndex = 27;
            this.btnEdt.Text = "Edit";
            this.btnEdt.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(702, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.Location = new System.Drawing.Point(789, 46);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 188);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.Location = new System.Drawing.Point(874, 46);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files(*.xlsx)|*.xlsx";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 13);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 15);
            this.lblModel.TabIndex = 38;
            this.lblModel.Text = "Model :";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(76, 10);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 23);
            this.cmbModel.TabIndex = 39;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(76, 48);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 41;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 51);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(47, 15);
            this.lblCategory.TabIndex = 40;
            this.lblCategory.Text = "분류 :";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Items.AddRange(new object[] {
            "수삽",
            "Tuning",
            "반조립",
            "Table_Fail",
            "Burning",
            "ATS1",
            "ATS2",
            "ICS1",
            "ICS2",
            "완조립",
            "포장",
            "출하",
            "수리"});
            this.cmbSubCategory.Location = new System.Drawing.Point(339, 31);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbSubCategory.TabIndex = 43;
            this.cmbSubCategory.SelectedValueChanged += new System.EventHandler(this.cmbSubCategory_SelectedValueChanged);
            // 
            // lblProcessCateg
            // 
            this.lblProcessCateg.AutoSize = true;
            this.lblProcessCateg.Location = new System.Drawing.Point(251, 34);
            this.lblProcessCateg.Name = "lblProcessCateg";
            this.lblProcessCateg.Size = new System.Drawing.Size(82, 15);
            this.lblProcessCateg.TabIndex = 42;
            this.lblProcessCateg.Text = "공정 분류 :";
            // 
            // grpBoxProcessData
            // 
            this.grpBoxProcessData.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.grpBoxProcessData.Controls.Add(this.grpBoxFixRepairList);
            this.grpBoxProcessData.Controls.Add(this.lblBurningTime);
            this.grpBoxProcessData.Controls.Add(this.btnFail);
            this.grpBoxProcessData.Controls.Add(this.btnTestPass);
            this.grpBoxProcessData.Controls.Add(this.btnProcessDataReset);
            this.grpBoxProcessData.Controls.Add(this.btnProcessDataInput);
            this.grpBoxProcessData.Controls.Add(this.cmbSubCategory);
            this.grpBoxProcessData.Controls.Add(this.dateTimePickerProductionDate);
            this.grpBoxProcessData.Controls.Add(this.lblProcessCateg);
            this.grpBoxProcessData.Controls.Add(this.lblProductionDate);
            this.grpBoxProcessData.Controls.Add(this.txtBxCartonBoxDCMSerial);
            this.grpBoxProcessData.Controls.Add(this.lblCartonBxDCMSerial);
            this.grpBoxProcessData.Controls.Add(this.txtBxGiftBxSerial);
            this.grpBoxProcessData.Controls.Add(this.lblGiftBoxSerial);
            this.grpBoxProcessData.Controls.Add(this.txtBxDCMSerial);
            this.grpBoxProcessData.Controls.Add(this.lblDCMSerial);
            this.grpBoxProcessData.Controls.Add(this.cmbTestItems);
            this.grpBoxProcessData.Controls.Add(this.lblTestItem);
            this.grpBoxProcessData.Controls.Add(this.cmbBurningYesNo);
            this.grpBoxProcessData.Controls.Add(this.lblBurningYesNo);
            this.grpBoxProcessData.Controls.Add(this.txtBxSerialNo);
            this.grpBoxProcessData.Controls.Add(this.lblSerialNo);
            this.grpBoxProcessData.Controls.Add(this.cmbErrorCategory);
            this.grpBoxProcessData.Controls.Add(this.lblErrorClassification);
            this.grpBoxProcessData.Controls.Add(this.dTPickerBurnStop);
            this.grpBoxProcessData.Controls.Add(this.dTPickerBurnStat);
            this.grpBoxProcessData.Controls.Add(this.lblStop);
            this.grpBoxProcessData.Controls.Add(this.lblStart);
            this.grpBoxProcessData.Controls.Add(this.lblDetails);
            this.grpBoxProcessData.Controls.Add(this.txtBxDetails);
            this.grpBoxProcessData.Controls.Add(this.cmbPathSelection);
            this.grpBoxProcessData.Controls.Add(this.lblPointOfError);
            this.grpBoxProcessData.Controls.Add(this.lblTestResult);
            this.grpBoxProcessData.Location = new System.Drawing.Point(219, 8);
            this.grpBoxProcessData.Name = "grpBoxProcessData";
            this.grpBoxProcessData.Size = new System.Drawing.Size(1149, 367);
            this.grpBoxProcessData.TabIndex = 67;
            this.grpBoxProcessData.TabStop = false;
            this.grpBoxProcessData.Text = "공정 Data 입력";
            // 
            // grpBoxFixRepairList
            // 
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstTableFail);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstFullInteg);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstICS2);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstICS1);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstATS2);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairATS1);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstPartialInteg);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstTuning);
            this.grpBoxFixRepairList.Controls.Add(this.lblRepairLstSoldering);
            this.grpBoxFixRepairList.Location = new System.Drawing.Point(8, 259);
            this.grpBoxFixRepairList.Name = "grpBoxFixRepairList";
            this.grpBoxFixRepairList.Size = new System.Drawing.Size(409, 100);
            this.grpBoxFixRepairList.TabIndex = 108;
            this.grpBoxFixRepairList.TabStop = false;
            this.grpBoxFixRepairList.Text = "수리요구 내역";
            // 
            // lblRepairLstTableFail
            // 
            this.lblRepairLstTableFail.AutoSize = true;
            this.lblRepairLstTableFail.Location = new System.Drawing.Point(255, 61);
            this.lblRepairLstTableFail.Name = "lblRepairLstTableFail";
            this.lblRepairLstTableFail.Size = new System.Drawing.Size(69, 15);
            this.lblRepairLstTableFail.TabIndex = 8;
            this.lblRepairLstTableFail.Text = "Table Fail";
            // 
            // lblRepairLstFullInteg
            // 
            this.lblRepairLstFullInteg.AutoSize = true;
            this.lblRepairLstFullInteg.Location = new System.Drawing.Point(166, 61);
            this.lblRepairLstFullInteg.Name = "lblRepairLstFullInteg";
            this.lblRepairLstFullInteg.Size = new System.Drawing.Size(79, 15);
            this.lblRepairLstFullInteg.TabIndex = 7;
            this.lblRepairLstFullInteg.Text = "완조립 Fail";
            // 
            // lblRepairLstICS2
            // 
            this.lblRepairLstICS2.AutoSize = true;
            this.lblRepairLstICS2.Location = new System.Drawing.Point(92, 61);
            this.lblRepairLstICS2.Name = "lblRepairLstICS2";
            this.lblRepairLstICS2.Size = new System.Drawing.Size(65, 15);
            this.lblRepairLstICS2.TabIndex = 6;
            this.lblRepairLstICS2.Text = "ICS2 Fail";
            // 
            // lblRepairLstICS1
            // 
            this.lblRepairLstICS1.AutoSize = true;
            this.lblRepairLstICS1.Location = new System.Drawing.Point(12, 61);
            this.lblRepairLstICS1.Name = "lblRepairLstICS1";
            this.lblRepairLstICS1.Size = new System.Drawing.Size(65, 15);
            this.lblRepairLstICS1.TabIndex = 5;
            this.lblRepairLstICS1.Text = "ICS1 Fail";
            // 
            // lblRepairLstATS2
            // 
            this.lblRepairLstATS2.AutoSize = true;
            this.lblRepairLstATS2.Location = new System.Drawing.Point(330, 30);
            this.lblRepairLstATS2.Name = "lblRepairLstATS2";
            this.lblRepairLstATS2.Size = new System.Drawing.Size(69, 15);
            this.lblRepairLstATS2.TabIndex = 4;
            this.lblRepairLstATS2.Text = "ATS2 Fail";
            // 
            // lblRepairATS1
            // 
            this.lblRepairATS1.AutoSize = true;
            this.lblRepairATS1.Location = new System.Drawing.Point(255, 30);
            this.lblRepairATS1.Name = "lblRepairATS1";
            this.lblRepairATS1.Size = new System.Drawing.Size(69, 15);
            this.lblRepairATS1.TabIndex = 3;
            this.lblRepairATS1.Text = "ATS1 Fail";
            // 
            // lblRepairLstPartialInteg
            // 
            this.lblRepairLstPartialInteg.AutoSize = true;
            this.lblRepairLstPartialInteg.Location = new System.Drawing.Point(166, 30);
            this.lblRepairLstPartialInteg.Name = "lblRepairLstPartialInteg";
            this.lblRepairLstPartialInteg.Size = new System.Drawing.Size(79, 15);
            this.lblRepairLstPartialInteg.TabIndex = 2;
            this.lblRepairLstPartialInteg.Text = "반조립 Fail";
            // 
            // lblRepairLstTuning
            // 
            this.lblRepairLstTuning.AutoSize = true;
            this.lblRepairLstTuning.Location = new System.Drawing.Point(92, 30);
            this.lblRepairLstTuning.Name = "lblRepairLstTuning";
            this.lblRepairLstTuning.Size = new System.Drawing.Size(64, 15);
            this.lblRepairLstTuning.TabIndex = 1;
            this.lblRepairLstTuning.Text = "튜닝 Fail";
            // 
            // lblRepairLstSoldering
            // 
            this.lblRepairLstSoldering.AutoSize = true;
            this.lblRepairLstSoldering.Location = new System.Drawing.Point(12, 30);
            this.lblRepairLstSoldering.Name = "lblRepairLstSoldering";
            this.lblRepairLstSoldering.Size = new System.Drawing.Size(64, 15);
            this.lblRepairLstSoldering.TabIndex = 0;
            this.lblRepairLstSoldering.Text = "수삽 Fail";
            // 
            // lblBurningTime
            // 
            this.lblBurningTime.AutoSize = true;
            this.lblBurningTime.Location = new System.Drawing.Point(339, 74);
            this.lblBurningTime.Name = "lblBurningTime";
            this.lblBurningTime.Size = new System.Drawing.Size(91, 15);
            this.lblBurningTime.TabIndex = 97;
            this.lblBurningTime.Text = "Burning Time";
            // 
            // btnFail
            // 
            this.btnFail.Location = new System.Drawing.Point(583, 41);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(75, 23);
            this.btnFail.TabIndex = 96;
            this.btnFail.Text = "Fail";
            this.btnFail.UseVisualStyleBackColor = true;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // btnTestPass
            // 
            this.btnTestPass.Location = new System.Drawing.Point(583, 13);
            this.btnTestPass.Name = "btnTestPass";
            this.btnTestPass.Size = new System.Drawing.Size(75, 23);
            this.btnTestPass.TabIndex = 95;
            this.btnTestPass.Text = "Pass";
            this.btnTestPass.UseVisualStyleBackColor = true;
            this.btnTestPass.Click += new System.EventHandler(this.btnTestPass_Click);
            // 
            // btnProcessDataReset
            // 
            this.btnProcessDataReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcessDataReset.Location = new System.Drawing.Point(929, 239);
            this.btnProcessDataReset.Name = "btnProcessDataReset";
            this.btnProcessDataReset.Size = new System.Drawing.Size(122, 45);
            this.btnProcessDataReset.TabIndex = 94;
            this.btnProcessDataReset.Text = "공정 Data Reset";
            this.btnProcessDataReset.UseVisualStyleBackColor = true;
            // 
            // btnProcessDataInput
            // 
            this.btnProcessDataInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcessDataInput.Location = new System.Drawing.Point(801, 239);
            this.btnProcessDataInput.Name = "btnProcessDataInput";
            this.btnProcessDataInput.Size = new System.Drawing.Size(122, 45);
            this.btnProcessDataInput.TabIndex = 93;
            this.btnProcessDataInput.Text = "공정 Data 입력";
            this.btnProcessDataInput.UseVisualStyleBackColor = true;
            this.btnProcessDataInput.Click += new System.EventHandler(this.btnProcessDataInput_Click);
            // 
            // dateTimePickerProductionDate
            // 
            this.dateTimePickerProductionDate.Location = new System.Drawing.Point(129, 205);
            this.dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            this.dateTimePickerProductionDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerProductionDate.TabIndex = 92;
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(5, 212);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(121, 15);
            this.lblProductionDate.TabIndex = 91;
            this.lblProductionDate.Text = "Production date :";
            // 
            // txtBxCartonBoxDCMSerial
            // 
            this.txtBxCartonBoxDCMSerial.Location = new System.Drawing.Point(800, 169);
            this.txtBxCartonBoxDCMSerial.Name = "txtBxCartonBoxDCMSerial";
            this.txtBxCartonBoxDCMSerial.Size = new System.Drawing.Size(121, 25);
            this.txtBxCartonBoxDCMSerial.TabIndex = 90;
            // 
            // lblCartonBxDCMSerial
            // 
            this.lblCartonBxDCMSerial.AutoSize = true;
            this.lblCartonBxDCMSerial.Location = new System.Drawing.Point(585, 172);
            this.lblCartonBxDCMSerial.Name = "lblCartonBxDCMSerial";
            this.lblCartonBxDCMSerial.Size = new System.Drawing.Size(199, 15);
            this.lblCartonBxDCMSerial.TabIndex = 89;
            this.lblCartonBxDCMSerial.Text = "Carton Box DCM Serial No. :";
            // 
            // txtBxGiftBxSerial
            // 
            this.txtBxGiftBxSerial.Location = new System.Drawing.Point(445, 169);
            this.txtBxGiftBxSerial.Name = "txtBxGiftBxSerial";
            this.txtBxGiftBxSerial.Size = new System.Drawing.Size(121, 25);
            this.txtBxGiftBxSerial.TabIndex = 88;
            // 
            // lblGiftBoxSerial
            // 
            this.lblGiftBoxSerial.AutoSize = true;
            this.lblGiftBoxSerial.Location = new System.Drawing.Point(261, 172);
            this.lblGiftBoxSerial.Name = "lblGiftBoxSerial";
            this.lblGiftBoxSerial.Size = new System.Drawing.Size(178, 15);
            this.lblGiftBoxSerial.TabIndex = 87;
            this.lblGiftBoxSerial.Text = "Gift Box DCM Serial No. :";
            // 
            // txtBxDCMSerial
            // 
            this.txtBxDCMSerial.Location = new System.Drawing.Point(130, 169);
            this.txtBxDCMSerial.Name = "txtBxDCMSerial";
            this.txtBxDCMSerial.Size = new System.Drawing.Size(121, 25);
            this.txtBxDCMSerial.TabIndex = 86;
            // 
            // lblDCMSerial
            // 
            this.lblDCMSerial.AutoSize = true;
            this.lblDCMSerial.Location = new System.Drawing.Point(6, 172);
            this.lblDCMSerial.Name = "lblDCMSerial";
            this.lblDCMSerial.Size = new System.Drawing.Size(118, 15);
            this.lblDCMSerial.TabIndex = 85;
            this.lblDCMSerial.Text = "DCM Serial No. :";
            // 
            // cmbTestItems
            // 
            this.cmbTestItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestItems.FormattingEnabled = true;
            this.cmbTestItems.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.cmbTestItems.Location = new System.Drawing.Point(584, 97);
            this.cmbTestItems.Name = "cmbTestItems";
            this.cmbTestItems.Size = new System.Drawing.Size(121, 23);
            this.cmbTestItems.TabIndex = 84;
            // 
            // lblTestItem
            // 
            this.lblTestItem.AutoSize = true;
            this.lblTestItem.Location = new System.Drawing.Point(501, 105);
            this.lblTestItem.Name = "lblTestItem";
            this.lblTestItem.Size = new System.Drawing.Size(76, 15);
            this.lblTestItem.TabIndex = 83;
            this.lblTestItem.Text = "Test Item :";
            // 
            // cmbBurningYesNo
            // 
            this.cmbBurningYesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBurningYesNo.FormattingEnabled = true;
            this.cmbBurningYesNo.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.cmbBurningYesNo.Location = new System.Drawing.Point(583, 68);
            this.cmbBurningYesNo.Name = "cmbBurningYesNo";
            this.cmbBurningYesNo.Size = new System.Drawing.Size(121, 23);
            this.cmbBurningYesNo.TabIndex = 82;
            // 
            // lblBurningYesNo
            // 
            this.lblBurningYesNo.AutoSize = true;
            this.lblBurningYesNo.Location = new System.Drawing.Point(470, 74);
            this.lblBurningYesNo.Name = "lblBurningYesNo";
            this.lblBurningYesNo.Size = new System.Drawing.Size(107, 15);
            this.lblBurningYesNo.TabIndex = 81;
            this.lblBurningYesNo.Text = "Burning 유/무 :";
            // 
            // txtBxSerialNo
            // 
            this.txtBxSerialNo.Location = new System.Drawing.Point(118, 31);
            this.txtBxSerialNo.Name = "txtBxSerialNo";
            this.txtBxSerialNo.Size = new System.Drawing.Size(121, 25);
            this.txtBxSerialNo.TabIndex = 80;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(6, 34);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(106, 15);
            this.lblSerialNo.TabIndex = 79;
            this.lblSerialNo.Text = "CS Serial No. :";
            // 
            // cmbErrorCategory
            // 
            this.cmbErrorCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorCategory.FormattingEnabled = true;
            this.cmbErrorCategory.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.cmbErrorCategory.Location = new System.Drawing.Point(1011, 31);
            this.cmbErrorCategory.Name = "cmbErrorCategory";
            this.cmbErrorCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbErrorCategory.TabIndex = 78;
            // 
            // lblErrorClassification
            // 
            this.lblErrorClassification.AutoSize = true;
            this.lblErrorClassification.Location = new System.Drawing.Point(958, 34);
            this.lblErrorClassification.Name = "lblErrorClassification";
            this.lblErrorClassification.Size = new System.Drawing.Size(47, 15);
            this.lblErrorClassification.TabIndex = 77;
            this.lblErrorClassification.Text = "분류 :";
            // 
            // dTPickerBurnStop
            // 
            this.dTPickerBurnStop.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPickerBurnStop.Location = new System.Drawing.Point(113, 105);
            this.dTPickerBurnStop.Name = "dTPickerBurnStop";
            this.dTPickerBurnStop.Size = new System.Drawing.Size(200, 25);
            this.dTPickerBurnStop.TabIndex = 76;
            // 
            // dTPickerBurnStat
            // 
            this.dTPickerBurnStat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPickerBurnStat.Location = new System.Drawing.Point(112, 69);
            this.dTPickerBurnStat.Name = "dTPickerBurnStat";
            this.dTPickerBurnStat.Size = new System.Drawing.Size(200, 25);
            this.dTPickerBurnStat.TabIndex = 75;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(7, 112);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(100, 15);
            this.lblStop.TabIndex = 74;
            this.lblStop.Text = "Burning stop :";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(6, 74);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(99, 15);
            this.lblStart.TabIndex = 73;
            this.lblStart.Text = "Burning start :";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(734, 74);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(61, 15);
            this.lblDetails.TabIndex = 72;
            this.lblDetails.Text = "Details :";
            // 
            // txtBxDetails
            // 
            this.txtBxDetails.Location = new System.Drawing.Point(801, 68);
            this.txtBxDetails.Multiline = true;
            this.txtBxDetails.Name = "txtBxDetails";
            this.txtBxDetails.Size = new System.Drawing.Size(234, 86);
            this.txtBxDetails.TabIndex = 71;
            // 
            // cmbPathSelection
            // 
            this.cmbPathSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPathSelection.FormattingEnabled = true;
            this.cmbPathSelection.Items.AddRange(new object[] {
            "DL",
            "UL"});
            this.cmbPathSelection.Location = new System.Drawing.Point(801, 31);
            this.cmbPathSelection.Name = "cmbPathSelection";
            this.cmbPathSelection.Size = new System.Drawing.Size(121, 23);
            this.cmbPathSelection.TabIndex = 70;
            // 
            // lblPointOfError
            // 
            this.lblPointOfError.AutoSize = true;
            this.lblPointOfError.Location = new System.Drawing.Point(718, 34);
            this.lblPointOfError.Name = "lblPointOfError";
            this.lblPointOfError.Size = new System.Drawing.Size(77, 15);
            this.lblPointOfError.TabIndex = 69;
            this.lblPointOfError.Text = "이상지점 :";
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Location = new System.Drawing.Point(480, 34);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(97, 15);
            this.lblTestResult.TabIndex = 67;
            this.lblTestResult.Text = "테스트 통과 :";
            // 
            // grpSerialMatching
            // 
            this.grpSerialMatching.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.grpSerialMatching.Controls.Add(this.btnShippingDataReset);
            this.grpSerialMatching.Controls.Add(this.dateTimePicker4);
            this.grpSerialMatching.Controls.Add(this.btnShippingDataInput);
            this.grpSerialMatching.Controls.Add(this.txtBxProductionInputDCMSerialNo);
            this.grpSerialMatching.Controls.Add(this.label15);
            this.grpSerialMatching.Controls.Add(this.lblProductionDataDCMSerialNo);
            this.grpSerialMatching.Controls.Add(this.txtBxProductAdapterSerialNo);
            this.grpSerialMatching.Controls.Add(this.lblProductAdapterSerialNo);
            this.grpSerialMatching.Controls.Add(this.txtBxProductModemSerialNo);
            this.grpSerialMatching.Controls.Add(this.lblProductionModemSerialNo);
            this.grpSerialMatching.Controls.Add(this.txtBxProductCSSerialNo);
            this.grpSerialMatching.Controls.Add(this.lblProductCSserialNo);
            this.grpSerialMatching.Controls.Add(this.cmbProductionDataSelection);
            this.grpSerialMatching.Controls.Add(this.lblProductDataTypeSelection);
            this.grpSerialMatching.Location = new System.Drawing.Point(219, 394);
            this.grpSerialMatching.Name = "grpSerialMatching";
            this.grpSerialMatching.Size = new System.Drawing.Size(1149, 138);
            this.grpSerialMatching.TabIndex = 69;
            this.grpSerialMatching.TabStop = false;
            this.grpSerialMatching.Text = "Production Data 입력";
            // 
            // btnShippingDataReset
            // 
            this.btnShippingDataReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShippingDataReset.Location = new System.Drawing.Point(929, 16);
            this.btnShippingDataReset.Name = "btnShippingDataReset";
            this.btnShippingDataReset.Size = new System.Drawing.Size(122, 45);
            this.btnShippingDataReset.TabIndex = 96;
            this.btnShippingDataReset.Text = "출하 Data Reset";
            this.btnShippingDataReset.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(134, 96);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker4.TabIndex = 94;
            // 
            // btnShippingDataInput
            // 
            this.btnShippingDataInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShippingDataInput.Location = new System.Drawing.Point(801, 16);
            this.btnShippingDataInput.Name = "btnShippingDataInput";
            this.btnShippingDataInput.Size = new System.Drawing.Size(122, 45);
            this.btnShippingDataInput.TabIndex = 95;
            this.btnShippingDataInput.Text = "출하 Data 입력";
            this.btnShippingDataInput.UseVisualStyleBackColor = true;
            // 
            // txtBxProductionInputDCMSerialNo
            // 
            this.txtBxProductionInputDCMSerialNo.Location = new System.Drawing.Point(663, 54);
            this.txtBxProductionInputDCMSerialNo.Name = "txtBxProductionInputDCMSerialNo";
            this.txtBxProductionInputDCMSerialNo.Size = new System.Drawing.Size(121, 25);
            this.txtBxProductionInputDCMSerialNo.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 15);
            this.label15.TabIndex = 93;
            this.label15.Text = "Production date :";
            // 
            // lblProductionDataDCMSerialNo
            // 
            this.lblProductionDataDCMSerialNo.AutoSize = true;
            this.lblProductionDataDCMSerialNo.Location = new System.Drawing.Point(542, 59);
            this.lblProductionDataDCMSerialNo.Name = "lblProductionDataDCMSerialNo";
            this.lblProductionDataDCMSerialNo.Size = new System.Drawing.Size(118, 15);
            this.lblProductionDataDCMSerialNo.TabIndex = 105;
            this.lblProductionDataDCMSerialNo.Text = "DCM Serial No. :";
            // 
            // txtBxProductAdapterSerialNo
            // 
            this.txtBxProductAdapterSerialNo.Location = new System.Drawing.Point(386, 56);
            this.txtBxProductAdapterSerialNo.Name = "txtBxProductAdapterSerialNo";
            this.txtBxProductAdapterSerialNo.Size = new System.Drawing.Size(121, 25);
            this.txtBxProductAdapterSerialNo.TabIndex = 104;
            // 
            // lblProductAdapterSerialNo
            // 
            this.lblProductAdapterSerialNo.AutoSize = true;
            this.lblProductAdapterSerialNo.Location = new System.Drawing.Point(245, 59);
            this.lblProductAdapterSerialNo.Name = "lblProductAdapterSerialNo";
            this.lblProductAdapterSerialNo.Size = new System.Drawing.Size(135, 15);
            this.lblProductAdapterSerialNo.TabIndex = 103;
            this.lblProductAdapterSerialNo.Text = "Adapter Serial No. :";
            // 
            // txtBxProductModemSerialNo
            // 
            this.txtBxProductModemSerialNo.Location = new System.Drawing.Point(663, 16);
            this.txtBxProductModemSerialNo.Name = "txtBxProductModemSerialNo";
            this.txtBxProductModemSerialNo.Size = new System.Drawing.Size(121, 25);
            this.txtBxProductModemSerialNo.TabIndex = 102;
            // 
            // lblProductionModemSerialNo
            // 
            this.lblProductionModemSerialNo.AutoSize = true;
            this.lblProductionModemSerialNo.Location = new System.Drawing.Point(526, 21);
            this.lblProductionModemSerialNo.Name = "lblProductionModemSerialNo";
            this.lblProductionModemSerialNo.Size = new System.Drawing.Size(134, 15);
            this.lblProductionModemSerialNo.TabIndex = 101;
            this.lblProductionModemSerialNo.Text = "Modem Serial No. :";
            // 
            // txtBxProductCSSerialNo
            // 
            this.txtBxProductCSSerialNo.Location = new System.Drawing.Point(386, 18);
            this.txtBxProductCSSerialNo.Name = "txtBxProductCSSerialNo";
            this.txtBxProductCSSerialNo.Size = new System.Drawing.Size(121, 25);
            this.txtBxProductCSSerialNo.TabIndex = 100;
            // 
            // lblProductCSserialNo
            // 
            this.lblProductCSserialNo.AutoSize = true;
            this.lblProductCSserialNo.Location = new System.Drawing.Point(274, 21);
            this.lblProductCSserialNo.Name = "lblProductCSserialNo";
            this.lblProductCSserialNo.Size = new System.Drawing.Size(106, 15);
            this.lblProductCSserialNo.TabIndex = 99;
            this.lblProductCSserialNo.Text = "CS Serial No. :";
            // 
            // cmbProductionDataSelection
            // 
            this.cmbProductionDataSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductionDataSelection.FormattingEnabled = true;
            this.cmbProductionDataSelection.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.cmbProductionDataSelection.Location = new System.Drawing.Point(133, 18);
            this.cmbProductionDataSelection.Name = "cmbProductionDataSelection";
            this.cmbProductionDataSelection.Size = new System.Drawing.Size(121, 23);
            this.cmbProductionDataSelection.TabIndex = 98;
            // 
            // lblProductDataTypeSelection
            // 
            this.lblProductDataTypeSelection.AutoSize = true;
            this.lblProductDataTypeSelection.Location = new System.Drawing.Point(10, 21);
            this.lblProductDataTypeSelection.Name = "lblProductDataTypeSelection";
            this.lblProductDataTypeSelection.Size = new System.Drawing.Size(117, 15);
            this.lblProductDataTypeSelection.TabIndex = 97;
            this.lblProductDataTypeSelection.Text = "Serial Matching :";
            // 
            // grpBoxDataSearch
            // 
            this.grpBoxDataSearch.Controls.Add(this.label16);
            this.grpBoxDataSearch.Controls.Add(this.dataGridView1);
            this.grpBoxDataSearch.Controls.Add(this.cmbBxSrch);
            this.grpBoxDataSearch.Controls.Add(this.btnSrch);
            this.grpBoxDataSearch.Controls.Add(this.btnEdt);
            this.grpBoxDataSearch.Controls.Add(this.btnAdd);
            this.grpBoxDataSearch.Controls.Add(this.btnDel);
            this.grpBoxDataSearch.Controls.Add(this.btnExcel);
            this.grpBoxDataSearch.Controls.Add(this.label9);
            this.grpBoxDataSearch.Controls.Add(this.txtBxSrch);
            this.grpBoxDataSearch.Location = new System.Drawing.Point(219, 555);
            this.grpBoxDataSearch.Name = "grpBoxDataSearch";
            this.grpBoxDataSearch.Size = new System.Drawing.Size(1219, 279);
            this.grpBoxDataSearch.TabIndex = 70;
            this.grpBoxDataSearch.TabStop = false;
            this.grpBoxDataSearch.Text = "Data Search";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Search Category :";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(76, 630);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(121, 46);
            this.btnSetting.TabIndex = 71;
            this.btnSetting.Text = "Category Config";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // frmSearchAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1438, 852);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.grpBoxDataSearch);
            this.Controls.Add(this.grpSerialMatching);
            this.Controls.Add(this.grpBoxProcessData);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblModel);
            this.MaximizeBox = false;
            this.Name = "frmSearchAdmin";
            this.Text = "Shipped Products Management System";
            this.Load += new System.EventHandler(this.frmLoggedIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxProcessData.ResumeLayout(false);
            this.grpBoxProcessData.PerformLayout();
            this.grpBoxFixRepairList.ResumeLayout(false);
            this.grpBoxFixRepairList.PerformLayout();
            this.grpSerialMatching.ResumeLayout(false);
            this.grpSerialMatching.PerformLayout();
            this.grpBoxDataSearch.ResumeLayout(false);
            this.grpBoxDataSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxSrch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cmbBxSrch;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.Label lblProcessCateg;
        private System.Windows.Forms.GroupBox grpBoxProcessData;
        private System.Windows.Forms.ComboBox cmbBurningYesNo;
        private System.Windows.Forms.Label lblBurningYesNo;
        private System.Windows.Forms.TextBox txtBxSerialNo;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.ComboBox cmbErrorCategory;
        private System.Windows.Forms.Label lblErrorClassification;
        private System.Windows.Forms.DateTimePicker dTPickerBurnStop;
        private System.Windows.Forms.DateTimePicker dTPickerBurnStat;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtBxDetails;
        private System.Windows.Forms.ComboBox cmbPathSelection;
        private System.Windows.Forms.Label lblPointOfError;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.ComboBox cmbTestItems;
        private System.Windows.Forms.Label lblTestItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductionDate;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.TextBox txtBxCartonBoxDCMSerial;
        private System.Windows.Forms.Label lblCartonBxDCMSerial;
        private System.Windows.Forms.TextBox txtBxGiftBxSerial;
        private System.Windows.Forms.Label lblGiftBoxSerial;
        private System.Windows.Forms.TextBox txtBxDCMSerial;
        private System.Windows.Forms.Label lblDCMSerial;
        private System.Windows.Forms.GroupBox grpSerialMatching;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox txtBxProductionInputDCMSerialNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblProductionDataDCMSerialNo;
        private System.Windows.Forms.TextBox txtBxProductAdapterSerialNo;
        private System.Windows.Forms.Label lblProductAdapterSerialNo;
        private System.Windows.Forms.TextBox txtBxProductModemSerialNo;
        private System.Windows.Forms.Label lblProductionModemSerialNo;
        private System.Windows.Forms.TextBox txtBxProductCSSerialNo;
        private System.Windows.Forms.Label lblProductCSserialNo;
        private System.Windows.Forms.ComboBox cmbProductionDataSelection;
        private System.Windows.Forms.Label lblProductDataTypeSelection;
        private System.Windows.Forms.Button btnProcessDataReset;
        private System.Windows.Forms.Button btnProcessDataInput;
        private System.Windows.Forms.Button btnShippingDataReset;
        private System.Windows.Forms.Button btnShippingDataInput;
        private System.Windows.Forms.Button btnFail;
        private System.Windows.Forms.Button btnTestPass;
        private System.Windows.Forms.Label lblBurningTime;
        private System.Windows.Forms.GroupBox grpBoxFixRepairList;
        private System.Windows.Forms.Label lblRepairLstTableFail;
        private System.Windows.Forms.Label lblRepairLstFullInteg;
        private System.Windows.Forms.Label lblRepairLstICS2;
        private System.Windows.Forms.Label lblRepairLstICS1;
        private System.Windows.Forms.Label lblRepairLstATS2;
        private System.Windows.Forms.Label lblRepairATS1;
        private System.Windows.Forms.Label lblRepairLstPartialInteg;
        private System.Windows.Forms.Label lblRepairLstTuning;
        private System.Windows.Forms.Label lblRepairLstSoldering;
        private System.Windows.Forms.GroupBox grpBoxDataSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSetting;
    }
}