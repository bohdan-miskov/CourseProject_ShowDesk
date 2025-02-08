namespace CourseProject_ShowDesk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStagesForm));
            this.dataGridViewStages = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnZonesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripManageStages = new System.Windows.Forms.MenuStrip();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.contextMenuStripStages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.addStageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).BeginInit();
            this.menuStripManageStages.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripStages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.contextMenuStripAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStages
            // 
            this.dataGridViewStages.AllowUserToAddRows = false;
            this.dataGridViewStages.AllowUserToDeleteRows = false;
            this.dataGridViewStages.AllowUserToResizeRows = false;
            this.dataGridViewStages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStages.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnName,
            this.columnZonesCount});
            this.dataGridViewStages.ContextMenuStrip = this.contextMenuStripStages;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStages.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStages.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewStages.MultiSelect = false;
            this.dataGridViewStages.Name = "dataGridViewStages";
            this.dataGridViewStages.ReadOnly = true;
            this.dataGridViewStages.RowHeadersVisible = false;
            this.dataGridViewStages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStages.Size = new System.Drawing.Size(549, 196);
            this.dataGridViewStages.TabIndex = 2;
            this.dataGridViewStages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStages_RowEnter);
            this.dataGridViewStages.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStages_RowLeave);
            // 
            // columnNumber
            // 
            this.columnNumber.HeaderText = "Number";
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.ReadOnly = true;
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
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(373, 27);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 16;
            this.groupBoxProfile.TabStop = false;
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
            // addStageToolStripMenuItem1
            // 
            this.addStageToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addStageToolStripMenuItem1.Name = "addStageToolStripMenuItem1";
            this.addStageToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.addStageToolStripMenuItem1.Text = "Add stage";
            this.addStageToolStripMenuItem1.Click += new System.EventHandler(this.addStageToolStripMenuItem_Click);
            // 
            // editStageToolStripMenuItem1
            // 
            this.editStageToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editStageToolStripMenuItem1.Name = "editStageToolStripMenuItem1";
            this.editStageToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.editStageToolStripMenuItem1.Text = "Edit stage";
            this.editStageToolStripMenuItem1.Click += new System.EventHandler(this.editStageToolStripMenuItem_Click);
            // 
            // removeStageToolStripMenuItem1
            // 
            this.removeStageToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeStageToolStripMenuItem1.Name = "removeStageToolStripMenuItem1";
            this.removeStageToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.removeStageToolStripMenuItem1.Text = "Remove stage";
            this.removeStageToolStripMenuItem1.Click += new System.EventHandler(this.removeStageToolStripMenuItem_Click);
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
            this.addStageToolStripMenuItem.Click += new System.EventHandler(this.addStageToolStripMenuItem_Click);
            // 
            // editStageToolStripMenuItem
            // 
            this.editStageToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editStageToolStripMenuItem.Name = "editStageToolStripMenuItem";
            this.editStageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editStageToolStripMenuItem.Text = "Edit";
            this.editStageToolStripMenuItem.Click += new System.EventHandler(this.editStageToolStripMenuItem_Click);
            // 
            // removeStageToolStripMenuItem
            // 
            this.removeStageToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeStageToolStripMenuItem.Name = "removeStageToolStripMenuItem";
            this.removeStageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeStageToolStripMenuItem.Text = "Remove";
            this.removeStageToolStripMenuItem.Click += new System.EventHandler(this.removeStageToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ManageStagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 258);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.dataGridViewStages);
            this.Controls.Add(this.menuStripManageStages);
            this.Name = "ManageStagesForm";
            this.Text = "ManageStages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageStagesForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageStagesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).EndInit();
            this.menuStripManageStages.ResumeLayout(false);
            this.menuStripManageStages.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripStages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.contextMenuStripAccount.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnZonesCount;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStages;
        private System.Windows.Forms.ToolStripMenuItem addStageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeStageToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}