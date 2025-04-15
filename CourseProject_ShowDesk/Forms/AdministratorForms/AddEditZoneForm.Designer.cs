namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    partial class AddEditZoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditZoneForm));
            this.numericUpDownStartPosition = new System.Windows.Forms.NumericUpDown();
            this.groupBoxZone = new System.Windows.Forms.GroupBox();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.numericUpDownIncrease = new System.Windows.Forms.NumericUpDown();
            this.labelZoneName = new System.Windows.Forms.Label();
            this.labelEndPosition = new System.Windows.Forms.Label();
            this.textBoxZoneName = new System.Windows.Forms.TextBox();
            this.labelStartPosition = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownEndPosition = new System.Windows.Forms.NumericUpDown();
            this.labelIncrease = new System.Windows.Forms.Label();
            this.toolTipZone = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.panelViewport = new System.Windows.Forms.Panel();
            this.panelSeating = new System.Windows.Forms.Panel();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).BeginInit();
            this.groupBoxZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPosition)).BeginInit();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.panelViewport.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownStartPosition
            // 
            this.numericUpDownStartPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartPosition.Location = new System.Drawing.Point(174, 138);
            this.numericUpDownStartPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStartPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartPosition.Name = "numericUpDownStartPosition";
            this.numericUpDownStartPosition.Size = new System.Drawing.Size(168, 28);
            this.numericUpDownStartPosition.TabIndex = 19;
            this.numericUpDownStartPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartPosition.ValueChanged += new System.EventHandler(this.NumericUpDownStartPosition_ValueChanged);
            this.numericUpDownStartPosition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownStartPosition_KeyUp);
            // 
            // groupBoxZone
            // 
            this.groupBoxZone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxZone.Controls.Add(this.buttonChangeColor);
            this.groupBoxZone.Controls.Add(this.textBoxColor);
            this.groupBoxZone.Controls.Add(this.labelColor);
            this.groupBoxZone.Controls.Add(this.numericUpDownIncrease);
            this.groupBoxZone.Controls.Add(this.labelZoneName);
            this.groupBoxZone.Controls.Add(this.labelEndPosition);
            this.groupBoxZone.Controls.Add(this.textBoxZoneName);
            this.groupBoxZone.Controls.Add(this.labelStartPosition);
            this.groupBoxZone.Controls.Add(this.buttonAdd);
            this.groupBoxZone.Controls.Add(this.numericUpDownEndPosition);
            this.groupBoxZone.Controls.Add(this.labelIncrease);
            this.groupBoxZone.Controls.Add(this.numericUpDownStartPosition);
            this.groupBoxZone.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxZone.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxZone.Location = new System.Drawing.Point(20, 60);
            this.groupBoxZone.Name = "groupBoxZone";
            this.groupBoxZone.Size = new System.Drawing.Size(368, 257);
            this.groupBoxZone.TabIndex = 23;
            this.groupBoxZone.TabStop = false;
            this.groupBoxZone.Text = "Zone";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.color_change_icon;
            this.buttonChangeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChangeColor.Location = new System.Drawing.Point(175, 104);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(28, 28);
            this.buttonChangeColor.TabIndex = 27;
            this.buttonChangeColor.Text = " ";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.ButtonChangeColor_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.Color.White;
            this.textBoxColor.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(209, 104);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new System.Drawing.Size(133, 28);
            this.textBoxColor.TabIndex = 26;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(16, 111);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(92, 21);
            this.labelColor.TabIndex = 24;
            this.labelColor.Text = "Zone color";
            // 
            // numericUpDownIncrease
            // 
            this.numericUpDownIncrease.DecimalPlaces = 1;
            this.numericUpDownIncrease.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownIncrease.Location = new System.Drawing.Point(174, 70);
            this.numericUpDownIncrease.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownIncrease.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIncrease.Name = "numericUpDownIncrease";
            this.numericUpDownIncrease.Size = new System.Drawing.Size(168, 28);
            this.numericUpDownIncrease.TabIndex = 23;
            this.numericUpDownIncrease.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIncrease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxIncrease_KeyUp);
            // 
            // labelZoneName
            // 
            this.labelZoneName.AutoSize = true;
            this.labelZoneName.BackColor = System.Drawing.Color.Transparent;
            this.labelZoneName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName.Location = new System.Drawing.Point(16, 44);
            this.labelZoneName.Name = "labelZoneName";
            this.labelZoneName.Size = new System.Drawing.Size(94, 21);
            this.labelZoneName.TabIndex = 14;
            this.labelZoneName.Text = "Zone name";
            // 
            // labelEndPosition
            // 
            this.labelEndPosition.AutoSize = true;
            this.labelEndPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelEndPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndPosition.Location = new System.Drawing.Point(16, 179);
            this.labelEndPosition.Name = "labelEndPosition";
            this.labelEndPosition.Size = new System.Drawing.Size(109, 21);
            this.labelEndPosition.TabIndex = 22;
            this.labelEndPosition.Text = "End position";
            // 
            // textBoxZoneName
            // 
            this.textBoxZoneName.BackColor = System.Drawing.Color.White;
            this.textBoxZoneName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZoneName.Location = new System.Drawing.Point(174, 37);
            this.textBoxZoneName.Name = "textBoxZoneName";
            this.textBoxZoneName.Size = new System.Drawing.Size(168, 28);
            this.textBoxZoneName.TabIndex = 15;
            this.textBoxZoneName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxZoneName_KeyUp);
            // 
            // labelStartPosition
            // 
            this.labelStartPosition.AutoSize = true;
            this.labelStartPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelStartPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartPosition.Location = new System.Drawing.Point(16, 145);
            this.labelStartPosition.Name = "labelStartPosition";
            this.labelStartPosition.Size = new System.Drawing.Size(115, 21);
            this.labelStartPosition.TabIndex = 21;
            this.labelStartPosition.Text = "Start position";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(188, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 42);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Save";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // numericUpDownEndPosition
            // 
            this.numericUpDownEndPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEndPosition.Location = new System.Drawing.Point(174, 172);
            this.numericUpDownEndPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEndPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEndPosition.Name = "numericUpDownEndPosition";
            this.numericUpDownEndPosition.Size = new System.Drawing.Size(168, 28);
            this.numericUpDownEndPosition.TabIndex = 20;
            this.numericUpDownEndPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEndPosition.ValueChanged += new System.EventHandler(this.NumericUpDownEndPosition_ValueChanged);
            this.numericUpDownEndPosition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownEndPosition_KeyUp);
            // 
            // labelIncrease
            // 
            this.labelIncrease.AutoSize = true;
            this.labelIncrease.BackColor = System.Drawing.Color.Transparent;
            this.labelIncrease.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncrease.Location = new System.Drawing.Point(16, 75);
            this.labelIncrease.Name = "labelIncrease";
            this.labelIncrease.Size = new System.Drawing.Size(75, 21);
            this.labelIncrease.TabIndex = 17;
            this.labelIncrease.Text = "Increase";
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(867, 23);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 43;
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
            // panelViewport
            // 
            this.panelViewport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelViewport.Controls.Add(this.panelSeating);
            this.panelViewport.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelViewport.Location = new System.Drawing.Point(389, 60);
            this.panelViewport.Name = "panelViewport";
            this.panelViewport.Size = new System.Drawing.Size(645, 257);
            this.panelViewport.TabIndex = 44;
            // 
            // panelSeating
            // 
            this.panelSeating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSeating.Location = new System.Drawing.Point(-1000, -1000);
            this.panelSeating.Name = "panelSeating";
            this.panelSeating.Size = new System.Drawing.Size(3000, 3000);
            this.panelSeating.TabIndex = 7;
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripAccount";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(181, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.exit_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AddEditZoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 337);
            this.Controls.Add(this.panelViewport);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxZone);
            this.Name = "AddEditZoneForm";
            this.Text = "AddEditZone";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).EndInit();
            this.groupBoxZone.ResumeLayout(false);
            this.groupBoxZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPosition)).EndInit();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.panelViewport.ResumeLayout(false);
            this.contextMenuStripAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownStartPosition;
        private System.Windows.Forms.GroupBox groupBoxZone;
        private System.Windows.Forms.Label labelZoneName;
        private System.Windows.Forms.Label labelEndPosition;
        private System.Windows.Forms.TextBox textBoxZoneName;
        private System.Windows.Forms.Label labelStartPosition;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownEndPosition;
        private System.Windows.Forms.Label labelIncrease;
        private System.Windows.Forms.ToolTip toolTipZone;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrease;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Panel panelViewport;
        private System.Windows.Forms.Panel panelSeating;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}