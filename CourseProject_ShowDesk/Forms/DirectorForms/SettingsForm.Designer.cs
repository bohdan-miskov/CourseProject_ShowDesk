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
            this.labelPerformancesFileName = new System.Windows.Forms.Label();
            this.textBoxPerformancesFileName = new System.Windows.Forms.TextBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
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
            this.groupBoxFileName = new System.Windows.Forms.GroupBox();
            this.labelEmployeesFileName = new System.Windows.Forms.Label();
            this.textBoxEmployeesFileName = new System.Windows.Forms.TextBox();
            this.labelStagesFileName = new System.Windows.Forms.Label();
            this.textBoxStagesFileName = new System.Windows.Forms.TextBox();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeDateOfPastPerformances)).BeginInit();
            this.groupBoxNames.SuspendLayout();
            this.groupBoxPerformanceDuration.SuspendLayout();
            this.groupBoxTicketIncrease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPremiumIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardPlusIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardIncrease)).BeginInit();
            this.groupBoxFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPerformancesFileName
            // 
            this.labelPerformancesFileName.AutoSize = true;
            this.labelPerformancesFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelPerformancesFileName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformancesFileName.Location = new System.Drawing.Point(6, 104);
            this.labelPerformancesFileName.Name = "labelPerformancesFileName";
            this.labelPerformancesFileName.Size = new System.Drawing.Size(116, 21);
            this.labelPerformancesFileName.TabIndex = 0;
            this.labelPerformancesFileName.Text = "Performances";
            // 
            // textBoxPerformancesFileName
            // 
            this.textBoxPerformancesFileName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerformancesFileName.Location = new System.Drawing.Point(137, 101);
            this.textBoxPerformancesFileName.Name = "textBoxPerformancesFileName";
            this.textBoxPerformancesFileName.Size = new System.Drawing.Size(148, 28);
            this.textBoxPerformancesFileName.TabIndex = 1;
            this.textBoxPerformancesFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerformancesFileName_KeyPress);
            this.textBoxPerformancesFileName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPerformancesFileName_KeyUp);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxSettings.Controls.Add(this.groupBoxOther);
            this.groupBoxSettings.Controls.Add(this.buttonCancelChanges);
            this.groupBoxSettings.Controls.Add(this.buttonSaveChanges);
            this.groupBoxSettings.Controls.Add(this.groupBoxNames);
            this.groupBoxSettings.Controls.Add(this.groupBoxPerformanceDuration);
            this.groupBoxSettings.Controls.Add(this.groupBoxTicketIncrease);
            this.groupBoxSettings.Controls.Add(this.groupBoxFileName);
            this.groupBoxSettings.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSettings.Location = new System.Drawing.Point(2, 64);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(625, 530);
            this.groupBoxSettings.TabIndex = 2;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "App settings";
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxOther.Controls.Add(this.textBoxCurrencySymbol);
            this.groupBoxOther.Controls.Add(this.label1);
            this.groupBoxOther.Controls.Add(this.labelRangeDateOfPastPerformances);
            this.groupBoxOther.Controls.Add(this.numericUpDownRangeDateOfPastPerformances);
            this.groupBoxOther.Location = new System.Drawing.Point(21, 352);
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
            this.textBoxCurrencySymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCurrencySymbol_KeyPress);
            this.textBoxCurrencySymbol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCurrencySymbol_KeyUp);
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
            this.numericUpDownRangeDateOfPastPerformances.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownRangeDateOfPastPerformances_KeyUp);
            // 
            // buttonCancelChanges
            // 
            this.buttonCancelChanges.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelChanges.Location = new System.Drawing.Point(181, 468);
            this.buttonCancelChanges.Name = "buttonCancelChanges";
            this.buttonCancelChanges.Size = new System.Drawing.Size(125, 45);
            this.buttonCancelChanges.TabIndex = 8;
            this.buttonCancelChanges.Text = "Cancel";
            this.buttonCancelChanges.UseVisualStyleBackColor = false;
            this.buttonCancelChanges.Click += new System.EventHandler(this.buttonCancelChanges_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveChanges.Location = new System.Drawing.Point(21, 468);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(125, 45);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
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
            this.groupBoxNames.Location = new System.Drawing.Point(336, 197);
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
            this.buttonCancelName.Click += new System.EventHandler(this.buttonCancelName_Click);
            this.buttonCancelName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonCancelName_KeyUp);
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
            this.buttonSaveName.Click += new System.EventHandler(this.buttonSaveName_Click);
            this.buttonSaveName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonSaveName_KeyUp);
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
            this.textBoxItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItemName_KeyPress);
            this.textBoxItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxItemName_KeyUp);
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
            this.comboBoxListName.SelectedIndexChanged += new System.EventHandler(this.comboBoxListName_SelectedIndexChanged);
            this.comboBoxListName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxListName_KeyUp);
            // 
            // listBoxViewNames
            // 
            this.listBoxViewNames.FormattingEnabled = true;
            this.listBoxViewNames.ItemHeight = 21;
            this.listBoxViewNames.Location = new System.Drawing.Point(9, 70);
            this.listBoxViewNames.Name = "listBoxViewNames";
            this.listBoxViewNames.Size = new System.Drawing.Size(244, 151);
            this.listBoxViewNames.TabIndex = 0;
            this.listBoxViewNames.SelectedIndexChanged += new System.EventHandler(this.listBoxViewNames_SelectedIndexChanged);
            this.listBoxViewNames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxViewNames_KeyUp);
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
            this.groupBoxPerformanceDuration.Location = new System.Drawing.Point(21, 197);
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
            this.dateTimePickerMaxDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerMaxDuration_KeyUp);
            // 
            // dateTimePickerMinBreak
            // 
            this.dateTimePickerMinBreak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerMinBreak.Location = new System.Drawing.Point(144, 29);
            this.dateTimePickerMinBreak.Name = "dateTimePickerMinBreak";
            this.dateTimePickerMinBreak.ShowUpDown = true;
            this.dateTimePickerMinBreak.Size = new System.Drawing.Size(141, 28);
            this.dateTimePickerMinBreak.TabIndex = 6;
            this.dateTimePickerMinBreak.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerMinBreak_KeyUp);
            // 
            // dateTimePickerInitialDuration
            // 
            this.dateTimePickerInitialDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInitialDuration.Location = new System.Drawing.Point(144, 63);
            this.dateTimePickerInitialDuration.Name = "dateTimePickerInitialDuration";
            this.dateTimePickerInitialDuration.ShowUpDown = true;
            this.dateTimePickerInitialDuration.Size = new System.Drawing.Size(141, 28);
            this.dateTimePickerInitialDuration.TabIndex = 5;
            this.dateTimePickerInitialDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerInitialDuration_KeyUp);
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
            this.groupBoxTicketIncrease.Location = new System.Drawing.Point(335, 42);
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
            this.numericUpDownPremiumIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownPremiumIncrease_KeyUp);
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
            this.numericUpDownStandardPlusIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownStandardPlusIncrease_KeyUp);
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
            this.numericUpDownStandardIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownStandardIncrease_KeyUp);
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
            // groupBoxFileName
            // 
            this.groupBoxFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxFileName.Controls.Add(this.labelEmployeesFileName);
            this.groupBoxFileName.Controls.Add(this.textBoxEmployeesFileName);
            this.groupBoxFileName.Controls.Add(this.labelStagesFileName);
            this.groupBoxFileName.Controls.Add(this.textBoxStagesFileName);
            this.groupBoxFileName.Controls.Add(this.labelPerformancesFileName);
            this.groupBoxFileName.Controls.Add(this.textBoxPerformancesFileName);
            this.groupBoxFileName.Location = new System.Drawing.Point(21, 42);
            this.groupBoxFileName.Name = "groupBoxFileName";
            this.groupBoxFileName.Size = new System.Drawing.Size(308, 149);
            this.groupBoxFileName.TabIndex = 2;
            this.groupBoxFileName.TabStop = false;
            this.groupBoxFileName.Text = "FileName";
            // 
            // labelEmployeesFileName
            // 
            this.labelEmployeesFileName.AutoSize = true;
            this.labelEmployeesFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeesFileName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeesFileName.Location = new System.Drawing.Point(6, 36);
            this.labelEmployeesFileName.Name = "labelEmployeesFileName";
            this.labelEmployeesFileName.Size = new System.Drawing.Size(93, 21);
            this.labelEmployeesFileName.TabIndex = 4;
            this.labelEmployeesFileName.Text = "Employees";
            // 
            // textBoxEmployeesFileName
            // 
            this.textBoxEmployeesFileName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeesFileName.Location = new System.Drawing.Point(137, 33);
            this.textBoxEmployeesFileName.Name = "textBoxEmployeesFileName";
            this.textBoxEmployeesFileName.Size = new System.Drawing.Size(148, 28);
            this.textBoxEmployeesFileName.TabIndex = 5;
            this.textBoxEmployeesFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmployeesFileName_KeyPress);
            this.textBoxEmployeesFileName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEmployeesFileName_KeyUp);
            // 
            // labelStagesFileName
            // 
            this.labelStagesFileName.AutoSize = true;
            this.labelStagesFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelStagesFileName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStagesFileName.Location = new System.Drawing.Point(6, 70);
            this.labelStagesFileName.Name = "labelStagesFileName";
            this.labelStagesFileName.Size = new System.Drawing.Size(58, 21);
            this.labelStagesFileName.TabIndex = 2;
            this.labelStagesFileName.Text = "Stages";
            // 
            // textBoxStagesFileName
            // 
            this.textBoxStagesFileName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStagesFileName.Location = new System.Drawing.Point(137, 67);
            this.textBoxStagesFileName.Name = "textBoxStagesFileName";
            this.textBoxStagesFileName.Size = new System.Drawing.Size(148, 28);
            this.textBoxStagesFileName.TabIndex = 3;
            this.textBoxStagesFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStagesFileName_KeyPress);
            this.textBoxStagesFileName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStagesFileName_KeyUp);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 590);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBoxSettings.ResumeLayout(false);
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
            this.groupBoxFileName.ResumeLayout(false);
            this.groupBoxFileName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPerformancesFileName;
        private System.Windows.Forms.TextBox textBoxPerformancesFileName;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxFileName;
        private System.Windows.Forms.GroupBox groupBoxTicketIncrease;
        private System.Windows.Forms.Label labelStandardIncrease;
        private System.Windows.Forms.Label labelStandardPlusIncrease;
        private System.Windows.Forms.Label labelPremiumIncrease;
        private System.Windows.Forms.Label labelEmployeesFileName;
        private System.Windows.Forms.TextBox textBoxEmployeesFileName;
        private System.Windows.Forms.Label labelStagesFileName;
        private System.Windows.Forms.TextBox textBoxStagesFileName;
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
    }
}