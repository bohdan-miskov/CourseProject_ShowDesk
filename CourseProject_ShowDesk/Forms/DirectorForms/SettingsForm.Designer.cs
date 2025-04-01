namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.labelPerformancesCollectionName = new System.Windows.Forms.Label();
            this.textBoxPerformancesCollectionName = new System.Windows.Forms.TextBox();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.textBoxCurrencySymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRangeDateOfPastPerformances = new System.Windows.Forms.Label();
            this.numericUpDownRangeDateOfPastPerformances = new System.Windows.Forms.NumericUpDown();
            this.buttonCancelChanges = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.groupBoxNames = new System.Windows.Forms.GroupBox();
            this.buttonCancelName = new System.Windows.Forms.Button();
            this.buttonSaveName = new System.Windows.Forms.Button();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelListName = new System.Windows.Forms.Label();
            this.comboBoxListName = new System.Windows.Forms.ComboBox();
            this.listBoxViewNames = new System.Windows.Forms.ListBox();
            this.groupBoxPerformanceDuration = new System.Windows.Forms.GroupBox();
            this.dateTimePickerMaxDuration = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMinBreak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInitialDuration = new System.Windows.Forms.DateTimePicker();
            this.labelMinBreak = new System.Windows.Forms.Label();
            this.labelInitialDuration = new System.Windows.Forms.Label();
            this.labelMaxDuration = new System.Windows.Forms.Label();
            this.groupBoxTicketIncrease = new System.Windows.Forms.GroupBox();
            this.numericUpDownPremiumIncrease = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStandardPlusIncrease = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStandardIncrease = new System.Windows.Forms.NumericUpDown();
            this.labelStandardIncrease = new System.Windows.Forms.Label();
            this.labelStandardPlusIncrease = new System.Windows.Forms.Label();
            this.labelPremiumIncrease = new System.Windows.Forms.Label();
            this.groupBoxCollectionName = new System.Windows.Forms.GroupBox();
            this.labelEmployeesCollectionName = new System.Windows.Forms.Label();
            this.textBoxEmployeesCollectionName = new System.Windows.Forms.TextBox();
            this.labelStagesCollectionName = new System.Windows.Forms.Label();
            this.textBoxStagesCollectionName = new System.Windows.Forms.TextBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxDataBaseOther = new System.Windows.Forms.GroupBox();
            this.textBoxDataBaseLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeDateOfPastPerformances)).BeginInit();
            this.groupBoxNames.SuspendLayout();
            this.groupBoxPerformanceDuration.SuspendLayout();
            this.groupBoxTicketIncrease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPremiumIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardPlusIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardIncrease)).BeginInit();
            this.groupBoxCollectionName.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.tabControlSetting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxDataBaseOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPerformancesCollectionName
            // 
            this.labelPerformancesCollectionName.AutoSize = true;
            this.labelPerformancesCollectionName.BackColor = System.Drawing.Color.Transparent;
            this.labelPerformancesCollectionName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformancesCollectionName.Location = new System.Drawing.Point(6, 104);
            this.labelPerformancesCollectionName.Name = "labelPerformancesCollectionName";
            this.labelPerformancesCollectionName.Size = new System.Drawing.Size(116, 21);
            this.labelPerformancesCollectionName.TabIndex = 0;
            this.labelPerformancesCollectionName.Text = "Performances";
            // 
            // textBoxPerformancesCollectionName
            // 
            this.textBoxPerformancesCollectionName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerformancesCollectionName.Location = new System.Drawing.Point(137, 101);
            this.textBoxPerformancesCollectionName.Name = "textBoxPerformancesCollectionName";
            this.textBoxPerformancesCollectionName.Size = new System.Drawing.Size(148, 28);
            this.textBoxPerformancesCollectionName.TabIndex = 1;
            this.textBoxPerformancesCollectionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPerformancesFileName_KeyPress);
            this.textBoxPerformancesCollectionName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPerformancesFileName_KeyUp);
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxOther.Controls.Add(this.textBoxCurrencySymbol);
            this.groupBoxOther.Controls.Add(this.label1);
            this.groupBoxOther.Controls.Add(this.labelRangeDateOfPastPerformances);
            this.groupBoxOther.Controls.Add(this.numericUpDownRangeDateOfPastPerformances);
            this.groupBoxOther.Location = new System.Drawing.Point(6, 326);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(308, 110);
            this.groupBoxOther.TabIndex = 9;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "Other";
            // 
            // textBoxCurrencySymbol
            // 
            this.textBoxCurrencySymbol.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrencySymbol.Location = new System.Drawing.Point(182, 72);
            this.textBoxCurrencySymbol.MaxLength = 1;
            this.textBoxCurrencySymbol.Name = "textBoxCurrencySymbol";
            this.textBoxCurrencySymbol.Size = new System.Drawing.Size(120, 28);
            this.textBoxCurrencySymbol.TabIndex = 7;
            this.textBoxCurrencySymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCurrencySymbol_KeyPress);
            this.textBoxCurrencySymbol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxCurrencySymbol_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Currency symbol";
            // 
            // labelRangeDateOfPastPerformances
            // 
            this.labelRangeDateOfPastPerformances.AutoSize = true;
            this.labelRangeDateOfPastPerformances.BackColor = System.Drawing.Color.Transparent;
            this.labelRangeDateOfPastPerformances.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRangeDateOfPastPerformances.Location = new System.Drawing.Point(6, 28);
            this.labelRangeDateOfPastPerformances.Name = "labelRangeDateOfPastPerformances";
            this.labelRangeDateOfPastPerformances.Size = new System.Drawing.Size(149, 42);
            this.labelRangeDateOfPastPerformances.TabIndex = 6;
            this.labelRangeDateOfPastPerformances.Text = "Range of view of\r\npast performances";
            // 
            // numericUpDownRangeDateOfPastPerformances
            // 
            this.numericUpDownRangeDateOfPastPerformances.Location = new System.Drawing.Point(182, 38);
            this.numericUpDownRangeDateOfPastPerformances.Name = "numericUpDownRangeDateOfPastPerformances";
            this.numericUpDownRangeDateOfPastPerformances.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownRangeDateOfPastPerformances.TabIndex = 8;
            this.numericUpDownRangeDateOfPastPerformances.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownRangeDateOfPastPerformances_KeyUp);
            // 
            // buttonCancelChanges
            // 
            this.buttonCancelChanges.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelChanges.Location = new System.Drawing.Point(166, 442);
            this.buttonCancelChanges.Name = "buttonCancelChanges";
            this.buttonCancelChanges.Size = new System.Drawing.Size(125, 45);
            this.buttonCancelChanges.TabIndex = 8;
            this.buttonCancelChanges.Text = "Cancel";
            this.buttonCancelChanges.UseVisualStyleBackColor = false;
            this.buttonCancelChanges.Click += new System.EventHandler(this.ButtonCancelChanges_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveChanges.Location = new System.Drawing.Point(6, 442);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(125, 45);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
            // 
            // groupBoxNames
            // 
            this.groupBoxNames.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxNames.Controls.Add(this.buttonCancelName);
            this.groupBoxNames.Controls.Add(this.buttonSaveName);
            this.groupBoxNames.Controls.Add(this.labelItemName);
            this.groupBoxNames.Controls.Add(this.textBoxItemName);
            this.groupBoxNames.Controls.Add(this.labelListName);
            this.groupBoxNames.Controls.Add(this.comboBoxListName);
            this.groupBoxNames.Controls.Add(this.listBoxViewNames);
            this.groupBoxNames.Location = new System.Drawing.Point(321, 171);
            this.groupBoxNames.Name = "groupBoxNames";
            this.groupBoxNames.Size = new System.Drawing.Size(275, 316);
            this.groupBoxNames.TabIndex = 5;
            this.groupBoxNames.TabStop = false;
            this.groupBoxNames.Text = "Names";
            // 
            // buttonCancelName
            // 
            this.buttonCancelName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelName.Location = new System.Drawing.Point(145, 269);
            this.buttonCancelName.Name = "buttonCancelName";
            this.buttonCancelName.Size = new System.Drawing.Size(108, 32);
            this.buttonCancelName.TabIndex = 6;
            this.buttonCancelName.Text = "Cancel";
            this.buttonCancelName.UseVisualStyleBackColor = false;
            this.buttonCancelName.Click += new System.EventHandler(this.ButtonCancelName_Click);
            this.buttonCancelName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ButtonCancelName_KeyUp);
            // 
            // buttonSaveName
            // 
            this.buttonSaveName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveName.Location = new System.Drawing.Point(9, 269);
            this.buttonSaveName.Name = "buttonSaveName";
            this.buttonSaveName.Size = new System.Drawing.Size(108, 32);
            this.buttonSaveName.TabIndex = 5;
            this.buttonSaveName.Text = "Save name";
            this.buttonSaveName.UseVisualStyleBackColor = false;
            this.buttonSaveName.Click += new System.EventHandler(this.ButtonSaveName_Click);
            this.buttonSaveName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ButtonSaveName_KeyUp);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.BackColor = System.Drawing.Color.Transparent;
            this.labelItemName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(5, 230);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(92, 21);
            this.labelItemName.TabIndex = 3;
            this.labelItemName.Text = "Item name";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(99, 227);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(154, 28);
            this.textBoxItemName.TabIndex = 4;
            this.textBoxItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxItemName_KeyPress);
            this.textBoxItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxItemName_KeyUp);
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.BackColor = System.Drawing.Color.Transparent;
            this.labelListName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListName.Location = new System.Drawing.Point(5, 41);
            this.labelListName.Name = "labelListName";
            this.labelListName.Size = new System.Drawing.Size(88, 21);
            this.labelListName.TabIndex = 2;
            this.labelListName.Text = "List name";
            // 
            // comboBoxListName
            // 
            this.comboBoxListName.FormattingEnabled = true;
            this.comboBoxListName.Location = new System.Drawing.Point(99, 33);
            this.comboBoxListName.Name = "comboBoxListName";
            this.comboBoxListName.Size = new System.Drawing.Size(154, 29);
            this.comboBoxListName.TabIndex = 1;
            this.comboBoxListName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListName_SelectedIndexChanged);
            this.comboBoxListName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxListName_KeyUp);
            // 
            // listBoxViewNames
            // 
            this.listBoxViewNames.FormattingEnabled = true;
            this.listBoxViewNames.ItemHeight = 21;
            this.listBoxViewNames.Location = new System.Drawing.Point(9, 70);
            this.listBoxViewNames.Name = "listBoxViewNames";
            this.listBoxViewNames.Size = new System.Drawing.Size(244, 151);
            this.listBoxViewNames.TabIndex = 0;
            this.listBoxViewNames.SelectedIndexChanged += new System.EventHandler(this.ListBoxViewNames_SelectedIndexChanged);
            this.listBoxViewNames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBoxViewNames_KeyUp);
            // 
            // groupBoxPerformanceDuration
            // 
            this.groupBoxPerformanceDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPerformanceDuration.Controls.Add(this.dateTimePickerMaxDuration);
            this.groupBoxPerformanceDuration.Controls.Add(this.dateTimePickerMinBreak);
            this.groupBoxPerformanceDuration.Controls.Add(this.dateTimePickerInitialDuration);
            this.groupBoxPerformanceDuration.Controls.Add(this.labelMinBreak);
            this.groupBoxPerformanceDuration.Controls.Add(this.labelInitialDuration);
            this.groupBoxPerformanceDuration.Controls.Add(this.labelMaxDuration);
            this.groupBoxPerformanceDuration.Location = new System.Drawing.Point(6, 171);
            this.groupBoxPerformanceDuration.Name = "groupBoxPerformanceDuration";
            this.groupBoxPerformanceDuration.Size = new System.Drawing.Size(308, 149);
            this.groupBoxPerformanceDuration.TabIndex = 4;
            this.groupBoxPerformanceDuration.TabStop = false;
            this.groupBoxPerformanceDuration.Text = "Performance duration";
            // 
            // dateTimePickerMaxDuration
            // 
            this.dateTimePickerMaxDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerMaxDuration.Location = new System.Drawing.Point(144, 97);
            this.dateTimePickerMaxDuration.Name = "dateTimePickerMaxDuration";
            this.dateTimePickerMaxDuration.ShowUpDown = true;
            this.dateTimePickerMaxDuration.Size = new System.Drawing.Size(141, 28);
            this.dateTimePickerMaxDuration.TabIndex = 7;
            this.dateTimePickerMaxDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerMaxDuration_KeyUp);
            // 
            // dateTimePickerMinBreak
            // 
            this.dateTimePickerMinBreak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerMinBreak.Location = new System.Drawing.Point(144, 29);
            this.dateTimePickerMinBreak.Name = "dateTimePickerMinBreak";
            this.dateTimePickerMinBreak.ShowUpDown = true;
            this.dateTimePickerMinBreak.Size = new System.Drawing.Size(141, 28);
            this.dateTimePickerMinBreak.TabIndex = 6;
            this.dateTimePickerMinBreak.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerMinBreak_KeyUp);
            // 
            // dateTimePickerInitialDuration
            // 
            this.dateTimePickerInitialDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInitialDuration.Location = new System.Drawing.Point(144, 63);
            this.dateTimePickerInitialDuration.Name = "dateTimePickerInitialDuration";
            this.dateTimePickerInitialDuration.ShowUpDown = true;
            this.dateTimePickerInitialDuration.Size = new System.Drawing.Size(141, 28);
            this.dateTimePickerInitialDuration.TabIndex = 5;
            this.dateTimePickerInitialDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerInitialDuration_KeyUp);
            // 
            // labelMinBreak
            // 
            this.labelMinBreak.AutoSize = true;
            this.labelMinBreak.BackColor = System.Drawing.Color.Transparent;
            this.labelMinBreak.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinBreak.Location = new System.Drawing.Point(6, 36);
            this.labelMinBreak.Name = "labelMinBreak";
            this.labelMinBreak.Size = new System.Drawing.Size(90, 21);
            this.labelMinBreak.TabIndex = 4;
            this.labelMinBreak.Text = "Min break";
            // 
            // labelInitialDuration
            // 
            this.labelInitialDuration.AutoSize = true;
            this.labelInitialDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelInitialDuration.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialDuration.Location = new System.Drawing.Point(6, 70);
            this.labelInitialDuration.Name = "labelInitialDuration";
            this.labelInitialDuration.Size = new System.Drawing.Size(132, 21);
            this.labelInitialDuration.TabIndex = 2;
            this.labelInitialDuration.Text = "Initial duration";
            // 
            // labelMaxDuration
            // 
            this.labelMaxDuration.AutoSize = true;
            this.labelMaxDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxDuration.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxDuration.Location = new System.Drawing.Point(6, 104);
            this.labelMaxDuration.Name = "labelMaxDuration";
            this.labelMaxDuration.Size = new System.Drawing.Size(115, 21);
            this.labelMaxDuration.TabIndex = 0;
            this.labelMaxDuration.Text = "Max duration";
            // 
            // groupBoxTicketIncrease
            // 
            this.groupBoxTicketIncrease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxTicketIncrease.Controls.Add(this.numericUpDownPremiumIncrease);
            this.groupBoxTicketIncrease.Controls.Add(this.numericUpDownStandardPlusIncrease);
            this.groupBoxTicketIncrease.Controls.Add(this.numericUpDownStandardIncrease);
            this.groupBoxTicketIncrease.Controls.Add(this.labelStandardIncrease);
            this.groupBoxTicketIncrease.Controls.Add(this.labelStandardPlusIncrease);
            this.groupBoxTicketIncrease.Controls.Add(this.labelPremiumIncrease);
            this.groupBoxTicketIncrease.Location = new System.Drawing.Point(320, 16);
            this.groupBoxTicketIncrease.Name = "groupBoxTicketIncrease";
            this.groupBoxTicketIncrease.Size = new System.Drawing.Size(276, 149);
            this.groupBoxTicketIncrease.TabIndex = 3;
            this.groupBoxTicketIncrease.TabStop = false;
            this.groupBoxTicketIncrease.Text = "Ticket increase";
            // 
            // numericUpDownPremiumIncrease
            // 
            this.numericUpDownPremiumIncrease.DecimalPlaces = 2;
            this.numericUpDownPremiumIncrease.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPremiumIncrease.Location = new System.Drawing.Point(134, 101);
            this.numericUpDownPremiumIncrease.Name = "numericUpDownPremiumIncrease";
            this.numericUpDownPremiumIncrease.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownPremiumIncrease.TabIndex = 8;
            this.numericUpDownPremiumIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownPremiumIncrease_KeyUp);
            // 
            // numericUpDownStandardPlusIncrease
            // 
            this.numericUpDownStandardPlusIncrease.DecimalPlaces = 2;
            this.numericUpDownStandardPlusIncrease.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStandardPlusIncrease.Location = new System.Drawing.Point(134, 63);
            this.numericUpDownStandardPlusIncrease.Name = "numericUpDownStandardPlusIncrease";
            this.numericUpDownStandardPlusIncrease.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownStandardPlusIncrease.TabIndex = 7;
            this.numericUpDownStandardPlusIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownStandardPlusIncrease_KeyUp);
            // 
            // numericUpDownStandardIncrease
            // 
            this.numericUpDownStandardIncrease.DecimalPlaces = 2;
            this.numericUpDownStandardIncrease.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStandardIncrease.Location = new System.Drawing.Point(134, 29);
            this.numericUpDownStandardIncrease.Name = "numericUpDownStandardIncrease";
            this.numericUpDownStandardIncrease.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownStandardIncrease.TabIndex = 6;
            this.numericUpDownStandardIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownStandardIncrease_KeyUp);
            // 
            // labelStandardIncrease
            // 
            this.labelStandardIncrease.AutoSize = true;
            this.labelStandardIncrease.BackColor = System.Drawing.Color.Transparent;
            this.labelStandardIncrease.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStandardIncrease.Location = new System.Drawing.Point(6, 36);
            this.labelStandardIncrease.Name = "labelStandardIncrease";
            this.labelStandardIncrease.Size = new System.Drawing.Size(79, 21);
            this.labelStandardIncrease.TabIndex = 4;
            this.labelStandardIncrease.Text = "Standard";
            // 
            // labelStandardPlusIncrease
            // 
            this.labelStandardPlusIncrease.AutoSize = true;
            this.labelStandardPlusIncrease.BackColor = System.Drawing.Color.Transparent;
            this.labelStandardPlusIncrease.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStandardPlusIncrease.Location = new System.Drawing.Point(6, 70);
            this.labelStandardPlusIncrease.Name = "labelStandardPlusIncrease";
            this.labelStandardPlusIncrease.Size = new System.Drawing.Size(114, 21);
            this.labelStandardPlusIncrease.TabIndex = 2;
            this.labelStandardPlusIncrease.Text = "StandardPlus";
            // 
            // labelPremiumIncrease
            // 
            this.labelPremiumIncrease.AutoSize = true;
            this.labelPremiumIncrease.BackColor = System.Drawing.Color.Transparent;
            this.labelPremiumIncrease.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPremiumIncrease.Location = new System.Drawing.Point(6, 104);
            this.labelPremiumIncrease.Name = "labelPremiumIncrease";
            this.labelPremiumIncrease.Size = new System.Drawing.Size(81, 21);
            this.labelPremiumIncrease.TabIndex = 0;
            this.labelPremiumIncrease.Text = "Premium";
            // 
            // groupBoxCollectionName
            // 
            this.groupBoxCollectionName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCollectionName.Controls.Add(this.labelEmployeesCollectionName);
            this.groupBoxCollectionName.Controls.Add(this.textBoxEmployeesCollectionName);
            this.groupBoxCollectionName.Controls.Add(this.labelStagesCollectionName);
            this.groupBoxCollectionName.Controls.Add(this.textBoxStagesCollectionName);
            this.groupBoxCollectionName.Controls.Add(this.labelPerformancesCollectionName);
            this.groupBoxCollectionName.Controls.Add(this.textBoxPerformancesCollectionName);
            this.groupBoxCollectionName.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCollectionName.Name = "groupBoxCollectionName";
            this.groupBoxCollectionName.Size = new System.Drawing.Size(308, 159);
            this.groupBoxCollectionName.TabIndex = 2;
            this.groupBoxCollectionName.TabStop = false;
            this.groupBoxCollectionName.Text = "ColectionName";
            // 
            // labelEmployeesCollectionName
            // 
            this.labelEmployeesCollectionName.AutoSize = true;
            this.labelEmployeesCollectionName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeesCollectionName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeesCollectionName.Location = new System.Drawing.Point(6, 36);
            this.labelEmployeesCollectionName.Name = "labelEmployeesCollectionName";
            this.labelEmployeesCollectionName.Size = new System.Drawing.Size(93, 21);
            this.labelEmployeesCollectionName.TabIndex = 4;
            this.labelEmployeesCollectionName.Text = "Employees";
            // 
            // textBoxEmployeesCollectionName
            // 
            this.textBoxEmployeesCollectionName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeesCollectionName.Location = new System.Drawing.Point(137, 33);
            this.textBoxEmployeesCollectionName.Name = "textBoxEmployeesCollectionName";
            this.textBoxEmployeesCollectionName.Size = new System.Drawing.Size(148, 28);
            this.textBoxEmployeesCollectionName.TabIndex = 5;
            this.textBoxEmployeesCollectionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmployeesFileName_KeyPress);
            this.textBoxEmployeesCollectionName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmployeesFileName_KeyUp);
            // 
            // labelStagesCollectionName
            // 
            this.labelStagesCollectionName.AutoSize = true;
            this.labelStagesCollectionName.BackColor = System.Drawing.Color.Transparent;
            this.labelStagesCollectionName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStagesCollectionName.Location = new System.Drawing.Point(6, 70);
            this.labelStagesCollectionName.Name = "labelStagesCollectionName";
            this.labelStagesCollectionName.Size = new System.Drawing.Size(58, 21);
            this.labelStagesCollectionName.TabIndex = 2;
            this.labelStagesCollectionName.Text = "Stages";
            // 
            // textBoxStagesCollectionName
            // 
            this.textBoxStagesCollectionName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStagesCollectionName.Location = new System.Drawing.Point(137, 67);
            this.textBoxStagesCollectionName.Name = "textBoxStagesCollectionName";
            this.textBoxStagesCollectionName.Size = new System.Drawing.Size(148, 28);
            this.textBoxStagesCollectionName.TabIndex = 3;
            this.textBoxStagesCollectionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxStagesFileName_KeyPress);
            this.textBoxStagesCollectionName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxStagesFileName_KeyUp);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(446, 27);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 26;
            this.groupBoxProfile.TabStop = false;
            // 
            // pictureBoxAccountIcon
            // 
            this.pictureBoxAccountIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAccountIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAccountIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccountIcon.Image")));
            this.pictureBoxAccountIcon.Location = new System.Drawing.Point(4, 7);
            this.pictureBoxAccountIcon.Name = "pictureBoxAccountIcon";
            this.pictureBoxAccountIcon.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxAccountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountIcon.TabIndex = 1;
            this.pictureBoxAccountIcon.TabStop = false;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.Location = new System.Drawing.Point(33, 10);
            this.labelAccountName.MaximumSize = new System.Drawing.Size(110, 0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(92, 17);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "AccountName";
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Controls.Add(this.tabPage1);
            this.tabControlSetting.Controls.Add(this.tabPage2);
            this.tabControlSetting.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSetting.Location = new System.Drawing.Point(0, 63);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(632, 530);
            this.tabControlSetting.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.groupBoxOther);
            this.tabPage1.Controls.Add(this.buttonCancelChanges);
            this.tabPage1.Controls.Add(this.groupBoxTicketIncrease);
            this.tabPage1.Controls.Add(this.buttonSaveChanges);
            this.tabPage1.Controls.Add(this.groupBoxPerformanceDuration);
            this.tabPage1.Controls.Add(this.groupBoxNames);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.groupBoxDataBaseOther);
            this.tabPage2.Controls.Add(this.groupBoxCollectionName);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            // 
            // groupBoxDataBaseOther
            // 
            this.groupBoxDataBaseOther.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDataBaseOther.Controls.Add(this.textBoxDataBaseLink);
            this.groupBoxDataBaseOther.Controls.Add(this.label3);
            this.groupBoxDataBaseOther.Location = new System.Drawing.Point(6, 171);
            this.groupBoxDataBaseOther.Name = "groupBoxDataBaseOther";
            this.groupBoxDataBaseOther.Size = new System.Drawing.Size(298, 100);
            this.groupBoxDataBaseOther.TabIndex = 10;
            this.groupBoxDataBaseOther.TabStop = false;
            this.groupBoxDataBaseOther.Text = "Other";
            // 
            // textBoxDataBaseLink
            // 
            this.textBoxDataBaseLink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataBaseLink.Location = new System.Drawing.Point(10, 52);
            this.textBoxDataBaseLink.MaxLength = 1;
            this.textBoxDataBaseLink.Name = "textBoxDataBaseLink";
            this.textBoxDataBaseLink.Size = new System.Drawing.Size(279, 28);
            this.textBoxDataBaseLink.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database link";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 590);
            this.Controls.Add(this.tabControlSetting);
            this.Controls.Add(this.groupBoxProfile);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeDateOfPastPerformances)).EndInit();
            this.groupBoxNames.ResumeLayout(false);
            this.groupBoxNames.PerformLayout();
            this.groupBoxPerformanceDuration.ResumeLayout(false);
            this.groupBoxPerformanceDuration.PerformLayout();
            this.groupBoxTicketIncrease.ResumeLayout(false);
            this.groupBoxTicketIncrease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPremiumIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardPlusIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardIncrease)).EndInit();
            this.groupBoxCollectionName.ResumeLayout(false);
            this.groupBoxCollectionName.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.tabControlSetting.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxDataBaseOther.ResumeLayout(false);
            this.groupBoxDataBaseOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPerformancesCollectionName;
        private System.Windows.Forms.TextBox textBoxPerformancesCollectionName;
        private System.Windows.Forms.GroupBox groupBoxCollectionName;
        private System.Windows.Forms.GroupBox groupBoxTicketIncrease;
        private System.Windows.Forms.Label labelStandardIncrease;
        private System.Windows.Forms.Label labelStandardPlusIncrease;
        private System.Windows.Forms.Label labelPremiumIncrease;
        private System.Windows.Forms.Label labelEmployeesCollectionName;
        private System.Windows.Forms.TextBox textBoxEmployeesCollectionName;
        private System.Windows.Forms.Label labelStagesCollectionName;
        private System.Windows.Forms.TextBox textBoxStagesCollectionName;
        private System.Windows.Forms.GroupBox groupBoxPerformanceDuration;
        private System.Windows.Forms.Label labelMinBreak;
        private System.Windows.Forms.Label labelInitialDuration;
        private System.Windows.Forms.Label labelMaxDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaxDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerMinBreak;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitialDuration;
        private System.Windows.Forms.GroupBox groupBoxNames;
        private System.Windows.Forms.ListBox listBoxViewNames;
        private System.Windows.Forms.Label labelListName;
        private System.Windows.Forms.ComboBox comboBoxListName;
        private System.Windows.Forms.Button buttonCancelName;
        private System.Windows.Forms.Button buttonSaveName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeDateOfPastPerformances;
        private System.Windows.Forms.Label labelRangeDateOfPastPerformances;
        private System.Windows.Forms.NumericUpDown numericUpDownStandardIncrease;
        private System.Windows.Forms.NumericUpDown numericUpDownPremiumIncrease;
        private System.Windows.Forms.NumericUpDown numericUpDownStandardPlusIncrease;
        private System.Windows.Forms.Button buttonCancelChanges;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.TextBox textBoxCurrencySymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxDataBaseOther;
        private System.Windows.Forms.TextBox textBoxDataBaseLink;
        private System.Windows.Forms.Label label3;
    }
}