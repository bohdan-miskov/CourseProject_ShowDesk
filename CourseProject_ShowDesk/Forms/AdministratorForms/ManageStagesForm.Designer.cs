namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    partial class ManageStagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStagesForm));
            this.dataGridViewStages = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnZonesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allPositionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionsAddedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripStages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripManageStages = new System.Windows.Forms.MenuStrip();
            this.stageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).BeginInit();
            this.contextMenuStripStages.SuspendLayout();
            this.menuStripManageStages.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStages
            // 
            this.dataGridViewStages.AllowUserToAddRows = false;
            this.dataGridViewStages.AllowUserToDeleteRows = false;
            this.dataGridViewStages.AllowUserToResizeRows = false;
            this.dataGridViewStages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStages.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.columnName,
            this.columnZonesCount,
            this.allPositionsColumn,
            this.positionsAddedColumn});
            this.dataGridViewStages.ContextMenuStrip = this.contextMenuStripStages;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStages.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStages.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewStages.MultiSelect = false;
            this.dataGridViewStages.Name = "dataGridViewStages";
            this.dataGridViewStages.ReadOnly = true;
            this.dataGridViewStages.RowHeadersVisible = false;
            this.dataGridViewStages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStages.Size = new System.Drawing.Size(710, 270);
            this.dataGridViewStages.TabIndex = 2;
            this.dataGridViewStages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStages_RowEnter);
            this.dataGridViewStages.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStages_RowLeave);
            this.dataGridViewStages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewStages_KeyDown);
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
            // columnZonesCount
            // 
            this.columnZonesCount.HeaderText = "Zones count";
            this.columnZonesCount.Name = "columnZonesCount";
            this.columnZonesCount.ReadOnly = true;
            // 
            // allPositionsColumn
            // 
            this.allPositionsColumn.HeaderText = "All positions";
            this.allPositionsColumn.Name = "allPositionsColumn";
            this.allPositionsColumn.ReadOnly = true;
            // 
            // positionsAddedColumn
            // 
            this.positionsAddedColumn.HeaderText = "Positions added";
            this.positionsAddedColumn.Name = "positionsAddedColumn";
            this.positionsAddedColumn.ReadOnly = true;
            // 
            // contextMenuStripStages
            // 
            this.contextMenuStripStages.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripStages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStageToolStripMenuItem1,
            this.editStageToolStripMenuItem1,
            this.removeStageToolStripMenuItem1});
            this.contextMenuStripStages.Name = "contextMenuStripStages";
            this.contextMenuStripStages.Size = new System.Drawing.Size(162, 70);
            // 
            // addStageToolStripMenuItem1
            // 
            this.addStageToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addStageToolStripMenuItem1.Name = "addStageToolStripMenuItem1";
            this.addStageToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.addStageToolStripMenuItem1.Text = "Add stage";
            this.addStageToolStripMenuItem1.Click += new System.EventHandler(this.AddStageToolStripMenuItem_Click);
            // 
            // editStageToolStripMenuItem1
            // 
            this.editStageToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editStageToolStripMenuItem1.Name = "editStageToolStripMenuItem1";
            this.editStageToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.editStageToolStripMenuItem1.Text = "Edit stage";
            this.editStageToolStripMenuItem1.Click += new System.EventHandler(this.EditStageToolStripMenuItem_Click);
            // 
            // removeStageToolStripMenuItem1
            // 
            this.removeStageToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeStageToolStripMenuItem1.Name = "removeStageToolStripMenuItem1";
            this.removeStageToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.removeStageToolStripMenuItem1.Text = "Remove stage";
            this.removeStageToolStripMenuItem1.Click += new System.EventHandler(this.RemoveStageToolStripMenuItem_Click);
            // 
            // menuStripManageStages
            // 
            this.menuStripManageStages.BackColor = System.Drawing.Color.Azure;
            this.menuStripManageStages.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripManageStages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stageToolStripMenuItem});
            this.menuStripManageStages.Location = new System.Drawing.Point(0, 0);
            this.menuStripManageStages.Name = "menuStripManageStages";
            this.menuStripManageStages.Size = new System.Drawing.Size(72, 24);
            this.menuStripManageStages.TabIndex = 3;
            this.menuStripManageStages.Text = "menuStrip1";
            // 
            // stageToolStripMenuItem
            // 
            this.stageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStageToolStripMenuItem,
            this.editStageToolStripMenuItem,
            this.removeStageToolStripMenuItem});
            this.stageToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.stage_icon;
            this.stageToolStripMenuItem.Name = "stageToolStripMenuItem";
            this.stageToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.stageToolStripMenuItem.Text = "Stage";
            // 
            // addStageToolStripMenuItem
            // 
            this.addStageToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addStageToolStripMenuItem.Name = "addStageToolStripMenuItem";
            this.addStageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addStageToolStripMenuItem.Text = "Add";
            this.addStageToolStripMenuItem.Click += new System.EventHandler(this.AddStageToolStripMenuItem_Click);
            // 
            // editStageToolStripMenuItem
            // 
            this.editStageToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editStageToolStripMenuItem.Name = "editStageToolStripMenuItem";
            this.editStageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editStageToolStripMenuItem.Text = "Edit";
            this.editStageToolStripMenuItem.Click += new System.EventHandler(this.EditStageToolStripMenuItem_Click);
            // 
            // removeStageToolStripMenuItem
            // 
            this.removeStageToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeStageToolStripMenuItem.Name = "removeStageToolStripMenuItem";
            this.removeStageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeStageToolStripMenuItem.Text = "Remove";
            this.removeStageToolStripMenuItem.Click += new System.EventHandler(this.RemoveStageToolStripMenuItem_Click);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(563, 23);
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
            this.labelAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUpdate.Image = global::CourseProject_ShowDesk.Properties.Resources.restart_icon;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(532, 30);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 23;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.search_icon;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(422, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(26, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxSearchField
            // 
            this.textBoxSearchField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchField.Location = new System.Drawing.Point(277, 29);
            this.textBoxSearchField.Name = "textBoxSearchField";
            this.textBoxSearchField.Size = new System.Drawing.Size(144, 26);
            this.textBoxSearchField.TabIndex = 0;
            this.textBoxSearchField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchField_KeyUp);
            // 
            // ManageStagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchField);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.dataGridViewStages);
            this.Controls.Add(this.menuStripManageStages);
            this.Name = "ManageStagesForm";
            this.Text = "ManageStages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageStagesForm_FormClosing);
            this.Shown += new System.EventHandler(this.ManageStagesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).EndInit();
            this.contextMenuStripStages.ResumeLayout(false);
            this.menuStripManageStages.ResumeLayout(false);
            this.menuStripManageStages.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStages;
        private System.Windows.Forms.MenuStrip menuStripManageStages;
        private System.Windows.Forms.ToolStripMenuItem stageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStages;
        private System.Windows.Forms.ToolStripMenuItem addStageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeStageToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnZonesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn allPositionsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionsAddedColumn;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchField;
    }
}