namespace CourseProject_TheaterHub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxStage = new System.Windows.Forms.GroupBox();
            this.dataGridViewZones = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartSeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEndPositions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxZones = new System.Windows.Forms.GroupBox();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZones)).BeginInit();
            this.groupBoxZones.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.Location = new System.Drawing.Point(169, 89);
            this.buttonSave.MinimumSize = new System.Drawing.Size(120, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 37);
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
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(50, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 21);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelIndex
            // 
            this.labelIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(50, 29);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(54, 21);
            this.labelIndex.TabIndex = 4;
            this.labelIndex.Text = "Index";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(169, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 28);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(59, 26);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zoneToolStripMenuItem
            // 
            this.zoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addZoneToolStripMenuItem,
            this.editZoneToolStripMenuItem,
            this.removeZoneToolStripMenuItem});
            this.zoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            this.zoneToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.zoneToolStripMenuItem.Text = "Zone";
            // 
            // addZoneToolStripMenuItem
            // 
            this.addZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addZoneToolStripMenuItem.Name = "addZoneToolStripMenuItem";
            this.addZoneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addZoneToolStripMenuItem.Text = "Add";
            this.addZoneToolStripMenuItem.Click += new System.EventHandler(this.addZoneToolStripMenuItem_Click);
            // 
            // editZoneToolStripMenuItem
            // 
            this.editZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editZoneToolStripMenuItem.Name = "editZoneToolStripMenuItem";
            this.editZoneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editZoneToolStripMenuItem.Text = "Edit";
            this.editZoneToolStripMenuItem.Click += new System.EventHandler(this.editZoneToolStripMenuItem_Click);
            // 
            // removeZoneToolStripMenuItem
            // 
            this.removeZoneToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeZoneToolStripMenuItem.Name = "removeZoneToolStripMenuItem";
            this.removeZoneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removeZoneToolStripMenuItem.Text = "Remove";
            this.removeZoneToolStripMenuItem.Click += new System.EventHandler(this.removeZoneToolStripMenuItem_Click);
            // 
            // groupBoxStage
            // 
            this.groupBoxStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStage.Controls.Add(this.buttonSave);
            this.groupBoxStage.Controls.Add(this.textBoxIndex);
            this.groupBoxStage.Controls.Add(this.labelName);
            this.groupBoxStage.Controls.Add(this.labelIndex);
            this.groupBoxStage.Controls.Add(this.textBoxName);
            this.groupBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStage.Location = new System.Drawing.Point(6, 19);
            this.groupBoxStage.Name = "groupBoxStage";
            this.groupBoxStage.Size = new System.Drawing.Size(427, 132);
            this.groupBoxStage.TabIndex = 13;
            this.groupBoxStage.TabStop = false;
            this.groupBoxStage.Text = "Stage";
            // 
            // dataGridViewZones
            // 
            this.dataGridViewZones.AllowUserToAddRows = false;
            this.dataGridViewZones.AllowUserToDeleteRows = false;
            this.dataGridViewZones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.rolumnRate,
            this.columnStartSeads,
            this.columnEndPositions});
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
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // rolumnRate
            // 
            this.rolumnRate.HeaderText = "Rate";
            this.rolumnRate.Name = "rolumnRate";
            this.rolumnRate.ReadOnly = true;
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
            // groupBoxZones
            // 
            this.groupBoxZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxZones.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBoxForm.BackgroundImage = global::CourseProject_TheaterHub.Properties.Resources.formBackground;
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxForm.Controls.Add(this.groupBoxStage);
            this.groupBoxForm.Controls.Add(this.groupBoxZones);
            this.groupBoxForm.Location = new System.Drawing.Point(0, 66);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(470, 427);
            this.groupBoxForm.TabIndex = 15;
            this.groupBoxForm.TabStop = false;
            // 
            // EditStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 490);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EditStageForm";
            this.Text = "EditStageForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxStage.ResumeLayout(false);
            this.groupBoxStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZones)).EndInit();
            this.groupBoxZones.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeZoneToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxStage;
        private System.Windows.Forms.DataGridView dataGridViewZones;
        private System.Windows.Forms.GroupBox groupBoxZones;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolumnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartSeads;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndPositions;
        private System.Windows.Forms.GroupBox groupBoxForm;
    }
}