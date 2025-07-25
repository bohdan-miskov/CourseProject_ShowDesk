﻿namespace CourseProject_ShowDesk.Forms.CashierForms
{
    partial class BuyTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicketForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxReserved = new System.Windows.Forms.CheckBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxTicketType = new System.Windows.Forms.ComboBox();
            this.groupBoxTicket = new System.Windows.Forms.GroupBox();
            this.labelSeatInfo = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.groupBoxPremium = new System.Windows.Forms.GroupBox();
            this.comboBoxSouvenir = new System.Windows.Forms.ComboBox();
            this.labelSouvenir = new System.Windows.Forms.Label();
            this.groupBoxStandardPlus = new System.Windows.Forms.GroupBox();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.labelDrink = new System.Windows.Forms.Label();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.panelViewport = new System.Windows.Forms.Panel();
            this.panelSeating = new System.Windows.Forms.Panel();
            this.groupBoxTicket.SuspendLayout();
            this.groupBoxPremium.SuspendLayout();
            this.groupBoxStandardPlus.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.panelViewport.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(215, 188);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 36);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(142, 150);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(213, 28);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPrice_KeyUp);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(28, 157);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 21);
            this.labelPrice.TabIndex = 34;
            this.labelPrice.Text = "Price";
            // 
            // checkBoxReserved
            // 
            this.checkBoxReserved.AutoSize = true;
            this.checkBoxReserved.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReserved.Location = new System.Drawing.Point(32, 123);
            this.checkBoxReserved.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkBoxReserved.Name = "checkBoxReserved";
            this.checkBoxReserved.Size = new System.Drawing.Size(97, 25);
            this.checkBoxReserved.TabIndex = 2;
            this.checkBoxReserved.Text = "Reserved";
            this.checkBoxReserved.UseVisualStyleBackColor = true;
            this.checkBoxReserved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckBoxReserved_KeyUp);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(148, 40);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(213, 28);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxIndex_KeyUp);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(34, 47);
            this.labelId.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 21);
            this.labelId.TabIndex = 31;
            this.labelId.Text = "Id";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(34, 82);
            this.labelType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(48, 21);
            this.labelType.TabIndex = 29;
            this.labelType.Text = "Type";
            // 
            // comboBoxTicketType
            // 
            this.comboBoxTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTicketType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTicketType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTicketType.BackColor = System.Drawing.Color.White;
            this.comboBoxTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTicketType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTicketType.FormattingEnabled = true;
            this.comboBoxTicketType.Location = new System.Drawing.Point(148, 74);
            this.comboBoxTicketType.Name = "comboBoxTicketType";
            this.comboBoxTicketType.Size = new System.Drawing.Size(213, 29);
            this.comboBoxTicketType.TabIndex = 1;
            this.comboBoxTicketType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTicketType_SelectedIndexChanged);
            this.comboBoxTicketType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxTicketType_KeyUp);
            // 
            // groupBoxTicket
            // 
            this.groupBoxTicket.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxTicket.Controls.Add(this.labelSeatInfo);
            this.groupBoxTicket.Controls.Add(this.labelCurrency);
            this.groupBoxTicket.Controls.Add(this.groupBoxPremium);
            this.groupBoxTicket.Controls.Add(this.groupBoxStandardPlus);
            this.groupBoxTicket.Controls.Add(this.textBoxPrice);
            this.groupBoxTicket.Controls.Add(this.comboBoxTicketType);
            this.groupBoxTicket.Controls.Add(this.labelType);
            this.groupBoxTicket.Controls.Add(this.buttonAdd);
            this.groupBoxTicket.Controls.Add(this.labelId);
            this.groupBoxTicket.Controls.Add(this.labelPrice);
            this.groupBoxTicket.Controls.Add(this.textBoxId);
            this.groupBoxTicket.Controls.Add(this.checkBoxReserved);
            this.groupBoxTicket.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTicket.Location = new System.Drawing.Point(1, 65);
            this.groupBoxTicket.Name = "groupBoxTicket";
            this.groupBoxTicket.Size = new System.Drawing.Size(1177, 443);
            this.groupBoxTicket.TabIndex = 40;
            this.groupBoxTicket.TabStop = false;
            this.groupBoxTicket.Text = "Ticket";
            // 
            // labelSeatInfo
            // 
            this.labelSeatInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.labelSeatInfo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatInfo.Location = new System.Drawing.Point(367, 24);
            this.labelSeatInfo.Name = "labelSeatInfo";
            this.labelSeatInfo.Size = new System.Drawing.Size(139, 124);
            this.labelSeatInfo.TabIndex = 42;
            this.labelSeatInfo.Text = "Seat info";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrency.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(331, 152);
            this.labelCurrency.MinimumSize = new System.Drawing.Size(22, 24);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(22, 24);
            this.labelCurrency.TabIndex = 40;
            this.labelCurrency.Text = "$";
            // 
            // groupBoxPremium
            // 
            this.groupBoxPremium.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPremium.Controls.Add(this.comboBoxSouvenir);
            this.groupBoxPremium.Controls.Add(this.labelSouvenir);
            this.groupBoxPremium.Location = new System.Drawing.Point(23, 356);
            this.groupBoxPremium.Name = "groupBoxPremium";
            this.groupBoxPremium.Size = new System.Drawing.Size(336, 67);
            this.groupBoxPremium.TabIndex = 39;
            this.groupBoxPremium.TabStop = false;
            this.groupBoxPremium.Text = "Premium";
            // 
            // comboBoxSouvenir
            // 
            this.comboBoxSouvenir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSouvenir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSouvenir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSouvenir.BackColor = System.Drawing.Color.White;
            this.comboBoxSouvenir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSouvenir.FormattingEnabled = true;
            this.comboBoxSouvenir.Location = new System.Drawing.Point(119, 27);
            this.comboBoxSouvenir.Name = "comboBoxSouvenir";
            this.comboBoxSouvenir.Size = new System.Drawing.Size(182, 29);
            this.comboBoxSouvenir.TabIndex = 6;
            // 
            // labelSouvenir
            // 
            this.labelSouvenir.AutoSize = true;
            this.labelSouvenir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouvenir.Location = new System.Drawing.Point(11, 35);
            this.labelSouvenir.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelSouvenir.Name = "labelSouvenir";
            this.labelSouvenir.Size = new System.Drawing.Size(78, 21);
            this.labelSouvenir.TabIndex = 32;
            this.labelSouvenir.Text = "Souvenir";
            // 
            // groupBoxStandardPlus
            // 
            this.groupBoxStandardPlus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxStandardPlus.Controls.Add(this.comboBoxDrink);
            this.groupBoxStandardPlus.Controls.Add(this.labelDrink);
            this.groupBoxStandardPlus.Location = new System.Drawing.Point(23, 283);
            this.groupBoxStandardPlus.Name = "groupBoxStandardPlus";
            this.groupBoxStandardPlus.Size = new System.Drawing.Size(338, 67);
            this.groupBoxStandardPlus.TabIndex = 38;
            this.groupBoxStandardPlus.TabStop = false;
            this.groupBoxStandardPlus.Text = "Standard Plus";
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDrink.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDrink.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDrink.BackColor = System.Drawing.Color.White;
            this.comboBoxDrink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(119, 27);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(184, 29);
            this.comboBoxDrink.TabIndex = 5;
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrink.Location = new System.Drawing.Point(11, 35);
            this.labelDrink.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(57, 21);
            this.labelDrink.TabIndex = 32;
            this.labelDrink.Text = "Drink";
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(1008, 28);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 41;
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
            // panelViewport
            // 
            this.panelViewport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelViewport.Controls.Add(this.panelSeating);
            this.panelViewport.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelViewport.Location = new System.Drawing.Point(513, 60);
            this.panelViewport.Name = "panelViewport";
            this.panelViewport.Size = new System.Drawing.Size(645, 430);
            this.panelViewport.TabIndex = 42;
            // 
            // panelSeating
            // 
            this.panelSeating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSeating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSeating.Location = new System.Drawing.Point(-1000, -997);
            this.panelSeating.Name = "panelSeating";
            this.panelSeating.Size = new System.Drawing.Size(3000, 3000);
            this.panelSeating.TabIndex = 7;
            this.panelSeating.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseDown);
            this.panelSeating.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseMove);
            this.panelSeating.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseUp);
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 510);
            this.Controls.Add(this.panelViewport);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxTicket);
            this.Name = "BuyTicketForm";
            this.Resizable = false;
            this.Text = "BuyTicket";
            this.groupBoxTicket.ResumeLayout(false);
            this.groupBoxTicket.PerformLayout();
            this.groupBoxPremium.ResumeLayout(false);
            this.groupBoxPremium.PerformLayout();
            this.groupBoxStandardPlus.ResumeLayout(false);
            this.groupBoxStandardPlus.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.panelViewport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxReserved;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxTicketType;
        private System.Windows.Forms.GroupBox groupBoxTicket;
        private System.Windows.Forms.GroupBox groupBoxStandardPlus;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.Label labelDrink;
        private System.Windows.Forms.GroupBox groupBoxPremium;
        private System.Windows.Forms.ComboBox comboBoxSouvenir;
        private System.Windows.Forms.Label labelSouvenir;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelSeatInfo;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Panel panelViewport;
        private System.Windows.Forms.Panel panelSeating;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}