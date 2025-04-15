namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    partial class EditStageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStageForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStageName = new System.Windows.Forms.Label();
            this.textBoxStageName = new System.Windows.Forms.TextBox();
            this.menuStripStage = new System.Windows.Forms.MenuStrip();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxStage = new System.Windows.Forms.GroupBox();
            this.buttonEditSeating = new System.Windows.Forms.Button();
            this.dataGridViewZones = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIncrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartSeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEndPositions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripStage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addZoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editZoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeZoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxZones = new System.Windows.Forms.GroupBox();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripStage.SuspendLayout();
            this.groupBoxStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZones)).BeginInit();
            this.contextMenuStripStage.SuspendLayout();
            this.groupBoxZones.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.contextMenuStripAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Location = new System.Drawing.Point(197, 89);
            this.buttonSave.MinimumSize = new System.Drawing.Size(80, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 37);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelStageName
            // 
            this.labelStageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStageName.AutoSize = true;
            this.labelStageName.Location = new System.Drawing.Point(49, 45);
            this.labelStageName.Name = "labelStageName";
            this.labelStageName.Size = new System.Drawing.Size(97, 21);
            this.labelStageName.TabIndex = 6;
            this.labelStageName.Text = "Stage name";
            // 
            // textBoxStageName
            // 
            this.textBoxStageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStageName.Location = new System.Drawing.Point(168, 38);
            this.textBoxStageName.Name = "textBoxStageName";
            this.textBoxStageName.Size = new System.Drawing.Size(288, 28);
            this.textBoxStageName.TabIndex = 7;
            this.textBoxStageName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxStageName_KeyUp);
            // 
            // menuStripStage
            // 
            this.menuStripStage.BackColor = System.Drawing.Color.Azure;
            this.menuStripStage.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripStage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneToolStripMenuItem});
            this.menuStripStage.Location = new System.Drawing.Point(0, 0);
            this.menuStripStage.Name = "menuStripStage";
            this.menuStripStage.Size = new System.Drawing.Size(75, 26);
            this.menuStripStage.TabIndex = 12;
            this.menuStripStage.Text = "menuStrip1";
            // 
            // zoneToolStripMenuItem
            // 
            this.zoneToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.zoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addZoneToolStripMenuItem,
            this.editZoneToolStripMenuItem,
            this.removeZoneToolStripMenuItem});
            this.zoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.zone_icon;
            this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            this.zoneToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.zoneToolStripMenuItem.Text = "Zone";
            // 
            // addZoneToolStripMenuItem
            // 
            this.addZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addZoneToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addZoneToolStripMenuItem.Name = "addZoneToolStripMenuItem";
            this.addZoneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addZoneToolStripMenuItem.Text = "Add";
            this.addZoneToolStripMenuItem.Click += new System.EventHandler(this.AddZoneToolStripMenuItem_Click);
            // 
            // editZoneToolStripMenuItem
            // 
            this.editZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editZoneToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editZoneToolStripMenuItem.Name = "editZoneToolStripMenuItem";
            this.editZoneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editZoneToolStripMenuItem.Text = "Edit";
            this.editZoneToolStripMenuItem.Click += new System.EventHandler(this.EditZoneToolStripMenuItem_Click);
            // 
            // removeZoneToolStripMenuItem
            // 
            this.removeZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeZoneToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeZoneToolStripMenuItem.Name = "removeZoneToolStripMenuItem";
            this.removeZoneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removeZoneToolStripMenuItem.Text = "Remove";
            this.removeZoneToolStripMenuItem.Click += new System.EventHandler(this.RemoveZoneToolStripMenuItem_Click);
            // 
            // groupBoxStage
            // 
            this.groupBoxStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxStage.Controls.Add(this.buttonEditSeating);
            this.groupBoxStage.Controls.Add(this.buttonSave);
            this.groupBoxStage.Controls.Add(this.labelStageName);
            this.groupBoxStage.Controls.Add(this.textBoxStageName);
            this.groupBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStage.Location = new System.Drawing.Point(6, 19);
            this.groupBoxStage.Name = "groupBoxStage";
            this.groupBoxStage.Size = new System.Drawing.Size(483, 132);
            this.groupBoxStage.TabIndex = 13;
            this.groupBoxStage.TabStop = false;
            this.groupBoxStage.Text = "Stage";
            // 
            // buttonEditSeating
            // 
            this.buttonEditSeating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditSeating.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditSeating.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEditSeating.Location = new System.Drawing.Point(314, 89);
            this.buttonEditSeating.MinimumSize = new System.Drawing.Size(80, 0);
            this.buttonEditSeating.Name = "buttonEditSeating";
            this.buttonEditSeating.Size = new System.Drawing.Size(115, 37);
            this.buttonEditSeating.TabIndex = 9;
            this.buttonEditSeating.Text = "Edit Seating";
            this.buttonEditSeating.UseVisualStyleBackColor = false;
            this.buttonEditSeating.Click += new System.EventHandler(this.ButtonEditSeating_Click);
            // 
            // dataGridViewZones
            // 
            this.dataGridViewZones.AllowUserToAddRows = false;
            this.dataGridViewZones.AllowUserToDeleteRows = false;
            this.dataGridViewZones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewZones.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.columnName,
            this.columnIncrease,
            this.colorColumn,
            this.columnStartSeads,
            this.columnEndPositions});
            this.dataGridViewZones.ContextMenuStrip = this.contextMenuStripStage;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewZones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewZones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewZones.Location = new System.Drawing.Point(3, 24);
            this.dataGridViewZones.Name = "dataGridViewZones";
            this.dataGridViewZones.ReadOnly = true;
            this.dataGridViewZones.RowHeadersVisible = false;
            this.dataGridViewZones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZones.Size = new System.Drawing.Size(508, 237);
            this.dataGridViewZones.TabIndex = 12;
            this.dataGridViewZones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewZones_RowEnter);
            this.dataGridViewZones.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewZones_RowLeave);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnIncrease
            // 
            this.columnIncrease.HeaderText = "Increase";
            this.columnIncrease.Name = "columnIncrease";
            this.columnIncrease.ReadOnly = true;
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "Color";
            this.colorColumn.Name = "colorColumn";
            this.colorColumn.ReadOnly = true;
            // 
            // columnStartSeads
            // 
            this.columnStartSeads.HeaderText = "Start position";
            this.columnStartSeads.Name = "columnStartSeads";
            this.columnStartSeads.ReadOnly = true;
            // 
            // columnEndPositions
            // 
            this.columnEndPositions.HeaderText = "End position";
            this.columnEndPositions.Name = "columnEndPositions";
            this.columnEndPositions.ReadOnly = true;
            // 
            // contextMenuStripStage
            // 
            this.contextMenuStripStage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripStage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addZoneToolStripMenuItem1,
            this.editZoneToolStripMenuItem1,
            this.removeZoneToolStripMenuItem1});
            this.contextMenuStripStage.Name = "contextMenuStripStage";
            this.contextMenuStripStage.Size = new System.Drawing.Size(160, 70);
            // 
            // addZoneToolStripMenuItem1
            // 
            this.addZoneToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addZoneToolStripMenuItem1.Name = "addZoneToolStripMenuItem1";
            this.addZoneToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.addZoneToolStripMenuItem1.Text = "Add zone";
            this.addZoneToolStripMenuItem1.Click += new System.EventHandler(this.AddZoneToolStripMenuItem_Click);
            // 
            // editZoneToolStripMenuItem1
            // 
            this.editZoneToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editZoneToolStripMenuItem1.Name = "editZoneToolStripMenuItem1";
            this.editZoneToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.editZoneToolStripMenuItem1.Text = "Edit zone";
            this.editZoneToolStripMenuItem1.Click += new System.EventHandler(this.EditZoneToolStripMenuItem_Click);
            // 
            // removeZoneToolStripMenuItem1
            // 
            this.removeZoneToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeZoneToolStripMenuItem1.Name = "removeZoneToolStripMenuItem1";
            this.removeZoneToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.removeZoneToolStripMenuItem1.Text = "Remove zone";
            this.removeZoneToolStripMenuItem1.Click += new System.EventHandler(this.RemoveZoneToolStripMenuItem_Click);
            // 
            // groupBoxZones
            // 
            this.groupBoxZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxZones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxZones.Controls.Add(this.dataGridViewZones);
            this.groupBoxZones.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxZones.Location = new System.Drawing.Point(6, 157);
            this.groupBoxZones.Name = "groupBoxZones";
            this.groupBoxZones.Size = new System.Drawing.Size(514, 264);
            this.groupBoxZones.TabIndex = 14;
            this.groupBoxZones.TabStop = false;
            this.groupBoxZones.Text = "Zones";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxForm.Controls.Add(this.groupBoxStage);
            this.groupBoxForm.Controls.Add(this.groupBoxZones);
            this.groupBoxForm.Location = new System.Drawing.Point(0, 66);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(526, 427);
            this.groupBoxForm.TabIndex = 15;
            this.groupBoxForm.TabStop = false;
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(353, 29);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 17;
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
            // EditStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 490);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.menuStripStage);
            this.Name = "EditStageForm";
            this.Text = "EditStage";
            this.menuStripStage.ResumeLayout(false);
            this.menuStripStage.PerformLayout();
            this.groupBoxStage.ResumeLayout(false);
            this.groupBoxStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZones)).EndInit();
            this.contextMenuStripStage.ResumeLayout(false);
            this.groupBoxZones.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.contextMenuStripAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStageName;
        private System.Windows.Forms.TextBox textBoxStageName;
        private System.Windows.Forms.MenuStrip menuStripStage;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeZoneToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxStage;
        private System.Windows.Forms.DataGridView dataGridViewZones;
        private System.Windows.Forms.GroupBox groupBoxZones;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Button buttonEditSeating;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStage;
        private System.Windows.Forms.ToolStripMenuItem addZoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editZoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeZoneToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIncrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartSeads;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndPositions;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}