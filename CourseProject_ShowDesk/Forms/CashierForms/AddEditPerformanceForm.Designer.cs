namespace CourseProject_ShowDesk.Forms.CashierForms
{
    partial class AddEditPerformanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPerformanceForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelPerformanceName = new System.Windows.Forms.Label();
            this.labelBaseTicketPrice = new System.Windows.Forms.Label();
            this.labelPerfomanceDate = new System.Windows.Forms.Label();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.textBoxBaseTicketPrice = new System.Windows.Forms.TextBox();
            this.textBoxPerformanceName = new System.Windows.Forms.TextBox();
            this.dateTimePickerPerfomanceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.labelDuration = new System.Windows.Forms.Label();
            this.toolTipPerformance = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.groupBoxPerformance.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(198, 212);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 40);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.BackColor = System.Drawing.Color.Transparent;
            this.labelStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStage.Location = new System.Drawing.Point(26, 173);
            this.labelStage.Name = "labelStage";
            this.labelStage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelStage.Size = new System.Drawing.Size(51, 25);
            this.labelStage.TabIndex = 16;
            this.labelStage.Text = "Stage";
            // 
            // labelPerformanceName
            // 
            this.labelPerformanceName.AutoSize = true;
            this.labelPerformanceName.BackColor = System.Drawing.Color.Transparent;
            this.labelPerformanceName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformanceName.Location = new System.Drawing.Point(26, 71);
            this.labelPerformanceName.Name = "labelPerformanceName";
            this.labelPerformanceName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerformanceName.Size = new System.Drawing.Size(155, 25);
            this.labelPerformanceName.TabIndex = 15;
            this.labelPerformanceName.Text = "Performance name";
            // 
            // labelBaseTicketPrice
            // 
            this.labelBaseTicketPrice.AutoSize = true;
            this.labelBaseTicketPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseTicketPrice.Location = new System.Drawing.Point(26, 139);
            this.labelBaseTicketPrice.Name = "labelBaseTicketPrice";
            this.labelBaseTicketPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelBaseTicketPrice.Size = new System.Drawing.Size(103, 25);
            this.labelBaseTicketPrice.TabIndex = 14;
            this.labelBaseTicketPrice.Text = "Ticket price";
            // 
            // labelPerfomanceDate
            // 
            this.labelPerfomanceDate.AutoSize = true;
            this.labelPerfomanceDate.BackColor = System.Drawing.Color.Transparent;
            this.labelPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfomanceDate.Location = new System.Drawing.Point(26, 37);
            this.labelPerfomanceDate.Name = "labelPerfomanceDate";
            this.labelPerfomanceDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerfomanceDate.Size = new System.Drawing.Size(139, 25);
            this.labelPerfomanceDate.TabIndex = 13;
            this.labelPerfomanceDate.Text = "Perfomance date";
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStage.BackColor = System.Drawing.Color.Silver;
            this.comboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Location = new System.Drawing.Point(198, 170);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(222, 29);
            this.comboBoxStage.TabIndex = 4;
            this.comboBoxStage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxStage_KeyUp);
            // 
            // textBoxBaseTicketPrice
            // 
            this.textBoxBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaseTicketPrice.Location = new System.Drawing.Point(198, 136);
            this.textBoxBaseTicketPrice.Name = "textBoxBaseTicketPrice";
            this.textBoxBaseTicketPrice.Size = new System.Drawing.Size(222, 28);
            this.textBoxBaseTicketPrice.TabIndex = 3;
            this.toolTipPerformance.SetToolTip(this.textBoxBaseTicketPrice, "Base price, without increase");
            this.textBoxBaseTicketPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBaseTicketPrice_KeyPress);
            this.textBoxBaseTicketPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxBaseTicketPrice_KeyUp);
            // 
            // textBoxPerformanceName
            // 
            this.textBoxPerformanceName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerformanceName.Location = new System.Drawing.Point(198, 68);
            this.textBoxPerformanceName.Name = "textBoxPerformanceName";
            this.textBoxPerformanceName.Size = new System.Drawing.Size(222, 28);
            this.textBoxPerformanceName.TabIndex = 1;
            this.textBoxPerformanceName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPerformanceName_KeyUp);
            // 
            // dateTimePickerPerfomanceDate
            // 
            this.dateTimePickerPerfomanceDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPerfomanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPerfomanceDate.Location = new System.Drawing.Point(198, 34);
            this.dateTimePickerPerfomanceDate.MinDate = new System.DateTime(2025, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerPerfomanceDate.Name = "dateTimePickerPerfomanceDate";
            this.dateTimePickerPerfomanceDate.Size = new System.Drawing.Size(222, 28);
            this.dateTimePickerPerfomanceDate.TabIndex = 0;
            this.dateTimePickerPerfomanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerPerfomanceDate_KeyUp);
            // 
            // groupBoxPerformance
            // 
            this.groupBoxPerformance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPerformance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPerformance.Controls.Add(this.labelCurrency);
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerDuration);
            this.groupBoxPerformance.Controls.Add(this.labelDuration);
            this.groupBoxPerformance.Controls.Add(this.labelPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.buttonSave);
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.labelStage);
            this.groupBoxPerformance.Controls.Add(this.textBoxPerformanceName);
            this.groupBoxPerformance.Controls.Add(this.labelPerformanceName);
            this.groupBoxPerformance.Controls.Add(this.textBoxBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.labelBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.comboBoxStage);
            this.groupBoxPerformance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPerformance.Location = new System.Drawing.Point(1, 63);
            this.groupBoxPerformance.Name = "groupBoxPerformance";
            this.groupBoxPerformance.Size = new System.Drawing.Size(469, 276);
            this.groupBoxPerformance.TabIndex = 18;
            this.groupBoxPerformance.TabStop = false;
            this.groupBoxPerformance.Text = "Performance";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrency.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(396, 138);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(22, 24);
            this.labelCurrency.TabIndex = 41;
            this.labelCurrency.Text = "$";
            // 
            // dateTimePickerDuration
            // 
            this.dateTimePickerDuration.CustomFormat = "";
            this.dateTimePickerDuration.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDuration.Location = new System.Drawing.Point(198, 102);
            this.dateTimePickerDuration.MinDate = new System.DateTime(2025, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerDuration.Name = "dateTimePickerDuration";
            this.dateTimePickerDuration.ShowUpDown = true;
            this.dateTimePickerDuration.Size = new System.Drawing.Size(222, 28);
            this.dateTimePickerDuration.TabIndex = 2;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelDuration.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(26, 105);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelDuration.Size = new System.Drawing.Size(81, 25);
            this.labelDuration.TabIndex = 19;
            this.labelDuration.Text = "Duration";
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(279, 26);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 19;
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
            // AddEditPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 339);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxPerformance);
            this.Name = "AddEditPerformanceForm";
            this.Text = "AddPerformance";
            this.groupBoxPerformance.ResumeLayout(false);
            this.groupBoxPerformance.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelPerformanceName;
        private System.Windows.Forms.Label labelBaseTicketPrice;
        private System.Windows.Forms.Label labelPerfomanceDate;
        private System.Windows.Forms.ComboBox comboBoxStage;
        private System.Windows.Forms.TextBox textBoxBaseTicketPrice;
        private System.Windows.Forms.TextBox textBoxPerformanceName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPerfomanceDate;
        private System.Windows.Forms.GroupBox groupBoxPerformance;
        private System.Windows.Forms.ToolTip toolTipPerformance;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}