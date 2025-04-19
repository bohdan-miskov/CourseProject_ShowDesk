namespace CourseProject_ShowDesk.Forms.CashierForms
{
    partial class ManagePerformancesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePerformancesForm));
            this.dataGridViewPerformances = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPerformanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPerformanceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripPerformance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripManagePerformance = new System.Windows.Forms.MenuStrip();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelAccountName = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBoxPastPerformanceRange = new System.Windows.Forms.GroupBox();
            this.buttonCancelPastPerformance = new System.Windows.Forms.Button();
            this.buttonLoadPastPerformance = new System.Windows.Forms.Button();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerPastPerformancesEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerPastPerformancesStartDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearchField = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.addPerformanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editPerformanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removePerformanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformances)).BeginInit();
            this.contextMenuStripPerformance.SuspendLayout();
            this.menuStripManagePerformance.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            this.groupBoxPastPerformanceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPerformances
            // 
            this.dataGridViewPerformances.AllowUserToAddRows = false;
            this.dataGridViewPerformances.AllowUserToDeleteRows = false;
            this.dataGridViewPerformances.AllowUserToResizeRows = false;
            this.dataGridViewPerformances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPerformances.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPerformances.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerformances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPerformances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerformances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.columnPerformanceDate,
            this.ColumnPerformanceTime,
            this.columnName,
            this.columnPrice,
            this.columnDuration,
            this.columnStage,
            this.columnTicketsCount,
            this.columnSold,
            this.columnReserved});
            this.dataGridViewPerformances.ContextMenuStrip = this.contextMenuStripPerformance;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerformances.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPerformances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerformances.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPerformances.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewPerformances.MultiSelect = false;
            this.dataGridViewPerformances.Name = "dataGridViewPerformances";
            this.dataGridViewPerformances.ReadOnly = true;
            this.dataGridViewPerformances.RowHeadersVisible = false;
            this.dataGridViewPerformances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerformances.Size = new System.Drawing.Size(846, 259);
            this.dataGridViewPerformances.TabIndex = 3;
            this.dataGridViewPerformances.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPerformances_RowEnter);
            this.dataGridViewPerformances.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPerformances_RowLeave);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // columnPerformanceDate
            // 
            this.columnPerformanceDate.HeaderText = "Date";
            this.columnPerformanceDate.Name = "columnPerformanceDate";
            this.columnPerformanceDate.ReadOnly = true;
            // 
            // ColumnPerformanceTime
            // 
            this.ColumnPerformanceTime.HeaderText = "Time";
            this.ColumnPerformanceTime.Name = "ColumnPerformanceTime";
            this.ColumnPerformanceTime.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnDuration
            // 
            this.columnDuration.HeaderText = "Duration";
            this.columnDuration.Name = "columnDuration";
            this.columnDuration.ReadOnly = true;
            // 
            // columnStage
            // 
            this.columnStage.HeaderText = "Stage";
            this.columnStage.Name = "columnStage";
            this.columnStage.ReadOnly = true;
            // 
            // columnTicketsCount
            // 
            this.columnTicketsCount.HeaderText = "Tickets count";
            this.columnTicketsCount.Name = "columnTicketsCount";
            this.columnTicketsCount.ReadOnly = true;
            // 
            // columnSold
            // 
            this.columnSold.HeaderText = "Sold";
            this.columnSold.Name = "columnSold";
            this.columnSold.ReadOnly = true;
            // 
            // columnReserved
            // 
            this.columnReserved.HeaderText = "Reserved";
            this.columnReserved.Name = "columnReserved";
            this.columnReserved.ReadOnly = true;
            // 
            // contextMenuStripPerformance
            // 
            this.contextMenuStripPerformance.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripPerformance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPerformanceToolStripMenuItem1,
            this.editPerformanceToolStripMenuItem1,
            this.removePerformanceToolStripMenuItem1,
            this.ticketsToolStripMenuItem1,
            this.revenueReportToolStripMenuItem1});
            this.contextMenuStripPerformance.Name = "contextMenuStripPerformance";
            this.contextMenuStripPerformance.Size = new System.Drawing.Size(210, 114);
            // 
            // menuStripManagePerformance
            // 
            this.menuStripManagePerformance.BackColor = System.Drawing.Color.Azure;
            this.menuStripManagePerformance.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripManagePerformance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performanceToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.revenueReportToolStripMenuItem});
            this.menuStripManagePerformance.Location = new System.Drawing.Point(0, 0);
            this.menuStripManagePerformance.Name = "menuStripManagePerformance";
            this.menuStripManagePerformance.Size = new System.Drawing.Size(286, 26);
            this.menuStripManagePerformance.TabIndex = 4;
            this.menuStripManagePerformance.Text = "menuStripManagePerformance";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSwitch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitch.Location = new System.Drawing.Point(522, 27);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(99, 31);
            this.buttonSwitch.TabIndex = 5;
            this.buttonSwitch.Text = "Switch";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.ButtonSwitch_Click);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(709, 27);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 16;
            this.groupBoxProfile.TabStop = false;
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripAccount";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(106, 26);
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
            // timerUpdate
            // 
            this.timerUpdate.Interval = 300000;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // groupBoxPastPerformanceRange
            // 
            this.groupBoxPastPerformanceRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPastPerformanceRange.Controls.Add(this.buttonCancelPastPerformance);
            this.groupBoxPastPerformanceRange.Controls.Add(this.buttonLoadPastPerformance);
            this.groupBoxPastPerformanceRange.Controls.Add(this.labelEndDate);
            this.groupBoxPastPerformanceRange.Controls.Add(this.dateTimePickerPastPerformancesEndDate);
            this.groupBoxPastPerformanceRange.Controls.Add(this.labelStartDate);
            this.groupBoxPastPerformanceRange.Controls.Add(this.dateTimePickerPastPerformancesStartDate);
            this.groupBoxPastPerformanceRange.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPastPerformanceRange.Location = new System.Drawing.Point(269, 130);
            this.groupBoxPastPerformanceRange.Name = "groupBoxPastPerformanceRange";
            this.groupBoxPastPerformanceRange.Size = new System.Drawing.Size(304, 186);
            this.groupBoxPastPerformanceRange.TabIndex = 19;
            this.groupBoxPastPerformanceRange.TabStop = false;
            this.groupBoxPastPerformanceRange.Text = "Past performances range";
            // 
            // buttonCancelPastPerformance
            // 
            this.buttonCancelPastPerformance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelPastPerformance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelPastPerformance.Location = new System.Drawing.Point(170, 132);
            this.buttonCancelPastPerformance.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonCancelPastPerformance.Name = "buttonCancelPastPerformance";
            this.buttonCancelPastPerformance.Size = new System.Drawing.Size(108, 40);
            this.buttonCancelPastPerformance.TabIndex = 19;
            this.buttonCancelPastPerformance.Text = "Cancel";
            this.buttonCancelPastPerformance.UseVisualStyleBackColor = false;
            this.buttonCancelPastPerformance.Click += new System.EventHandler(this.ButtonCancelPastPerformance_Click);
            // 
            // buttonLoadPastPerformance
            // 
            this.buttonLoadPastPerformance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLoadPastPerformance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadPastPerformance.Location = new System.Drawing.Point(27, 132);
            this.buttonLoadPastPerformance.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonLoadPastPerformance.Name = "buttonLoadPastPerformance";
            this.buttonLoadPastPerformance.Size = new System.Drawing.Size(108, 40);
            this.buttonLoadPastPerformance.TabIndex = 18;
            this.buttonLoadPastPerformance.Text = "Save";
            this.buttonLoadPastPerformance.UseVisualStyleBackColor = false;
            this.buttonLoadPastPerformance.Click += new System.EventHandler(this.ButtonLoadPastPerformance_Click);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEndDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(12, 91);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelEndDate.Size = new System.Drawing.Size(79, 25);
            this.labelEndDate.TabIndex = 17;
            this.labelEndDate.Text = "End date";
            // 
            // dateTimePickerPastPerformancesEndDate
            // 
            this.dateTimePickerPastPerformancesEndDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerPastPerformancesEndDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPastPerformancesEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPastPerformancesEndDate.Location = new System.Drawing.Point(123, 91);
            this.dateTimePickerPastPerformancesEndDate.MinDate = new System.DateTime(2025, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerPastPerformancesEndDate.Name = "dateTimePickerPastPerformancesEndDate";
            this.dateTimePickerPastPerformancesEndDate.Size = new System.Drawing.Size(165, 28);
            this.dateTimePickerPastPerformancesEndDate.TabIndex = 16;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(12, 57);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelStartDate.Size = new System.Drawing.Size(85, 25);
            this.labelStartDate.TabIndex = 15;
            this.labelStartDate.Text = "Start date";
            // 
            // dateTimePickerPastPerformancesStartDate
            // 
            this.dateTimePickerPastPerformancesStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerPastPerformancesStartDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPastPerformancesStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPastPerformancesStartDate.Location = new System.Drawing.Point(123, 57);
            this.dateTimePickerPastPerformancesStartDate.MinDate = new System.DateTime(2025, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerPastPerformancesStartDate.Name = "dateTimePickerPastPerformancesStartDate";
            this.dateTimePickerPastPerformancesStartDate.Size = new System.Drawing.Size(165, 28);
            this.dateTimePickerPastPerformancesStartDate.TabIndex = 14;
            // 
            // textBoxSearchField
            // 
            this.textBoxSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchField.Location = new System.Drawing.Point(285, 31);
            this.textBoxSearchField.Name = "textBoxSearchField";
            this.textBoxSearchField.Size = new System.Drawing.Size(139, 26);
            this.textBoxSearchField.TabIndex = 21;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.search_icon;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(430, 31);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(26, 26);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUpdate.Image = global::CourseProject_ShowDesk.Properties.Resources.restart_icon;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(682, 33);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 20;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.exit_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            // addPerformanceToolStripMenuItem1
            // 
            this.addPerformanceToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addPerformanceToolStripMenuItem1.Name = "addPerformanceToolStripMenuItem1";
            this.addPerformanceToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.addPerformanceToolStripMenuItem1.Text = "Add performance";
            this.addPerformanceToolStripMenuItem1.Click += new System.EventHandler(this.AddPerformanceToolStripMenuItem_Click);
            // 
            // editPerformanceToolStripMenuItem1
            // 
            this.editPerformanceToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editPerformanceToolStripMenuItem1.Name = "editPerformanceToolStripMenuItem1";
            this.editPerformanceToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.editPerformanceToolStripMenuItem1.Text = "Edit performance";
            this.editPerformanceToolStripMenuItem1.Click += new System.EventHandler(this.EditPerformanceToolStripMenuItem_Click);
            // 
            // removePerformanceToolStripMenuItem1
            // 
            this.removePerformanceToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removePerformanceToolStripMenuItem1.Name = "removePerformanceToolStripMenuItem1";
            this.removePerformanceToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.removePerformanceToolStripMenuItem1.Text = "Remove performance";
            this.removePerformanceToolStripMenuItem1.Click += new System.EventHandler(this.RemovePerformanceToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem1
            // 
            this.ticketsToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.ticket_icon;
            this.ticketsToolStripMenuItem1.Name = "ticketsToolStripMenuItem1";
            this.ticketsToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.ticketsToolStripMenuItem1.Text = "Tickets";
            // 
            // revenueReportToolStripMenuItem1
            // 
            this.revenueReportToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.report_icon;
            this.revenueReportToolStripMenuItem1.Name = "revenueReportToolStripMenuItem1";
            this.revenueReportToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.revenueReportToolStripMenuItem1.Text = "Revenue report";
            this.revenueReportToolStripMenuItem1.Click += new System.EventHandler(this.RevenueReportToolStripMenuItem_Click);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPerformanceToolStripMenuItem,
            this.editPerformanceToolStripMenuItem,
            this.removePerformanceToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.performanceToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.performance_icon;
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.performanceToolStripMenuItem.Text = "Performance";
            // 
            // addPerformanceToolStripMenuItem
            // 
            this.addPerformanceToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPerformanceToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addPerformanceToolStripMenuItem.Name = "addPerformanceToolStripMenuItem";
            this.addPerformanceToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addPerformanceToolStripMenuItem.Text = "Add";
            this.addPerformanceToolStripMenuItem.Click += new System.EventHandler(this.AddPerformanceToolStripMenuItem_Click);
            // 
            // editPerformanceToolStripMenuItem
            // 
            this.editPerformanceToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPerformanceToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editPerformanceToolStripMenuItem.Name = "editPerformanceToolStripMenuItem";
            this.editPerformanceToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editPerformanceToolStripMenuItem.Text = "Edit";
            this.editPerformanceToolStripMenuItem.Click += new System.EventHandler(this.EditPerformanceToolStripMenuItem_Click);
            // 
            // removePerformanceToolStripMenuItem
            // 
            this.removePerformanceToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePerformanceToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removePerformanceToolStripMenuItem.Name = "removePerformanceToolStripMenuItem";
            this.removePerformanceToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removePerformanceToolStripMenuItem.Text = "Remove";
            this.removePerformanceToolStripMenuItem.Click += new System.EventHandler(this.RemovePerformanceToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.filter_icon;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.FilterToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.ticket_icon;
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.TicketsToolStripMenuItem_Click);
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueReportToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.report_icon;
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.revenueReportToolStripMenuItem.Text = "Report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.RevenueReportToolStripMenuItem_Click);
            // 
            // ManagePerformancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 339);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchField);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.groupBoxPastPerformanceRange);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.dataGridViewPerformances);
            this.Controls.Add(this.menuStripManagePerformance);
            this.Name = "ManagePerformancesForm";
            this.Text = "ManagePerformance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagePerformancesFormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManagePerformancesForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformances)).EndInit();
            this.contextMenuStripPerformance.ResumeLayout(false);
            this.menuStripManagePerformance.ResumeLayout(false);
            this.menuStripManagePerformance.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripAccount.ResumeLayout(false);
            this.groupBoxPastPerformanceRange.ResumeLayout(false);
            this.groupBoxPastPerformanceRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPerformances;
        private System.Windows.Forms.MenuStrip menuStripManagePerformance;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPerformance;
        private System.Windows.Forms.ToolStripMenuItem addPerformanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editPerformanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removePerformanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPerformanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPerformanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReserved;
        private System.Windows.Forms.GroupBox groupBoxPastPerformanceRange;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPastPerformancesEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPastPerformancesStartDate;
        private System.Windows.Forms.Button buttonLoadPastPerformance;
        private System.Windows.Forms.Button buttonCancelPastPerformance;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPerformanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPerformanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePerformanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearchField;
        private System.Windows.Forms.Button buttonSearch;
    }
}