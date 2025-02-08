namespace CourseProject_ShowDesk
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelStageName = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxStageName = new System.Windows.Forms.TextBox();
            this.menuStripStage = new System.Windows.Forms.MenuStrip();
            this.groupBoxStage = new System.Windows.Forms.GroupBox();
            this.buttonEditSeating = new System.Windows.Forms.Button();
            this.dataGridViewZones = new System.Windows.Forms.DataGridView();
            this.groupBoxZones = new System.Windows.Forms.GroupBox();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.contextMenuStripStage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIncrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartSeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEndPositions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addZoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editZoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeZoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripStage.SuspendLayout();
            this.groupBoxStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZones)).BeginInit();
            this.groupBoxZones.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.contextMenuStripStage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Location = new System.Drawing.Point(169, 89);
            this.buttonSave.MinimumSize = new System.Drawing.Size(80, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 37);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIndex.Enabled = false;
            this.textBoxIndex.Location = new System.Drawing.Point(169, 22);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(232, 28);
            this.textBoxIndex.TabIndex = 5;
            this.textBoxIndex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIndex_KeyUp);
            // 
            // labelStageName
            // 
            this.labelStageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStageName.AutoSize = true;
            this.labelStageName.Location = new System.Drawing.Point(50, 59);
            this.labelStageName.Name = "labelStageName";
            this.labelStageName.Size = new System.Drawing.Size(97, 21);
            this.labelStageName.TabIndex = 6;
            this.labelStageName.Text = "Stage name";
            // 
            // labelIndex
            // 
            this.labelIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(50, 29);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(98, 21);
            this.labelIndex.TabIndex = 4;
            this.labelIndex.Text = "Stage index";
            // 
            // textBoxStageName
            // 
            this.textBoxStageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStageName.Location = new System.Drawing.Point(169, 52);
            this.textBoxStageName.Name = "textBoxStageName";
            this.textBoxStageName.Size = new System.Drawing.Size(232, 28);
            this.textBoxStageName.TabIndex = 7;
            this.textBoxStageName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
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
            // groupBoxStage
            // 
            this.groupBoxStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxStage.Controls.Add(this.buttonEditSeating);
            this.groupBoxStage.Controls.Add(this.buttonSave);
            this.groupBoxStage.Controls.Add(this.textBoxIndex);
            this.groupBoxStage.Controls.Add(this.labelStageName);
            this.groupBoxStage.Controls.Add(this.labelIndex);
            this.groupBoxStage.Controls.Add(this.textBoxStageName);
            this.groupBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStage.Location = new System.Drawing.Point(6, 19);
            this.groupBoxStage.Name = "groupBoxStage";
            this.groupBoxStage.Size = new System.Drawing.Size(427, 132);
            this.groupBoxStage.TabIndex = 13;
            this.groupBoxStage.TabStop = false;
            this.groupBoxStage.Text = "Stage";
            // 
            // buttonEditSeating
            // 
            this.buttonEditSeating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditSeating.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditSeating.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEditSeating.Location = new System.Drawing.Point(286, 89);
            this.buttonEditSeating.MinimumSize = new System.Drawing.Size(80, 0);
            this.buttonEditSeating.Name = "buttonEditSeating";
            this.buttonEditSeating.Size = new System.Drawing.Size(115, 37);
            this.buttonEditSeating.TabIndex = 9;
            this.buttonEditSeating.Text = "Edit Seating";
            this.buttonEditSeating.UseVisualStyleBackColor = false;
            this.buttonEditSeating.Click += new System.EventHandler(this.buttonEditSeating_Click);
            // 
            // dataGridViewZones
            // 
            this.dataGridViewZones.AllowUserToAddRows = false;
            this.dataGridViewZones.AllowUserToDeleteRows = false;
            this.dataGridViewZones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZones.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnIncrease,
            this.columnStartSeads,
            this.columnEndPositions});
            this.dataGridViewZones.ContextMenuStrip = this.contextMenuStripStage;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.dataGridViewZones.Size = new System.Drawing.Size(452, 237);
            this.dataGridViewZones.TabIndex = 12;
            this.dataGridViewZones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewZones_RowEnter);
            this.dataGridViewZones.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewZones_RowLeave);
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
            this.groupBoxZones.Size = new System.Drawing.Size(458, 264);
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
            this.groupBoxForm.Size = new System.Drawing.Size(470, 427);
            this.groupBoxForm.TabIndex = 15;
            this.groupBoxForm.TabStop = false;
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
            // addZoneToolStripMenuItem1
            // 
            this.addZoneToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addZoneToolStripMenuItem1.Name = "addZoneToolStripMenuItem1";
            this.addZoneToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.addZoneToolStripMenuItem1.Text = "Add zone";
            this.addZoneToolStripMenuItem1.Click += new System.EventHandler(this.addZoneToolStripMenuItem_Click);
            // 
            // editZoneToolStripMenuItem1
            // 
            this.editZoneToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editZoneToolStripMenuItem1.Name = "editZoneToolStripMenuItem1";
            this.editZoneToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.editZoneToolStripMenuItem1.Text = "Edit zone";
            this.editZoneToolStripMenuItem1.Click += new System.EventHandler(this.editZoneToolStripMenuItem_Click);
            // 
            // removeZoneToolStripMenuItem1
            // 
            this.removeZoneToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeZoneToolStripMenuItem1.Name = "removeZoneToolStripMenuItem1";
            this.removeZoneToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.removeZoneToolStripMenuItem1.Text = "Remove zone";
            this.removeZoneToolStripMenuItem1.Click += new System.EventHandler(this.removeZoneToolStripMenuItem_Click);
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
            this.addZoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addZoneToolStripMenuItem.Text = "Add";
            this.addZoneToolStripMenuItem.Click += new System.EventHandler(this.addZoneToolStripMenuItem_Click);
            // 
            // editZoneToolStripMenuItem
            // 
            this.editZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editZoneToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editZoneToolStripMenuItem.Name = "editZoneToolStripMenuItem";
            this.editZoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editZoneToolStripMenuItem.Text = "Edit";
            this.editZoneToolStripMenuItem.Click += new System.EventHandler(this.editZoneToolStripMenuItem_Click);
            // 
            // removeZoneToolStripMenuItem
            // 
            this.removeZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeZoneToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeZoneToolStripMenuItem.Name = "removeZoneToolStripMenuItem";
            this.removeZoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeZoneToolStripMenuItem.Text = "Remove";
            this.removeZoneToolStripMenuItem.Click += new System.EventHandler(this.removeZoneToolStripMenuItem_Click);
            // 
            // EditStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 490);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.menuStripStage);
            this.Name = "EditStageForm";
            this.Text = "EditStage";
            this.menuStripStage.ResumeLayout(false);
            this.menuStripStage.PerformLayout();
            this.groupBoxStage.ResumeLayout(false);
            this.groupBoxStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZones)).EndInit();
            this.groupBoxZones.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.contextMenuStripStage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelStageName;
        private System.Windows.Forms.Label labelIndex;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIncrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartSeads;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndPositions;
    }
}