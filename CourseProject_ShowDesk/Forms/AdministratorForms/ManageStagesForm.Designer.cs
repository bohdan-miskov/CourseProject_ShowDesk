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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStages = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnZonesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripManageStages = new System.Windows.Forms.MenuStrip();
            this.stageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).BeginInit();
            this.menuStripManageStages.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnName,
            this.columnZonesCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStages.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.menuStripManageStages.Size = new System.Drawing.Size(56, 24);
            this.menuStripManageStages.TabIndex = 3;
            this.menuStripManageStages.Text = "menuStrip1";
            // 
            // stageToolStripMenuItem
            // 
            this.stageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStageToolStripMenuItem,
            this.editStageToolStripMenuItem,
            this.removeStageToolStripMenuItem});
            this.stageToolStripMenuItem.Name = "stageToolStripMenuItem";
            this.stageToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stageToolStripMenuItem.Text = "Stage";
            // 
            // addStageToolStripMenuItem
            // 
            this.addStageToolStripMenuItem.Name = "addStageToolStripMenuItem";
            this.addStageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStageToolStripMenuItem.Text = "Add";
            this.addStageToolStripMenuItem.Click += new System.EventHandler(this.addStageToolStripMenuItem_Click);
            // 
            // editStageToolStripMenuItem
            // 
            this.editStageToolStripMenuItem.Name = "editStageToolStripMenuItem";
            this.editStageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editStageToolStripMenuItem.Text = "Edit";
            this.editStageToolStripMenuItem.Click += new System.EventHandler(this.editStageToolStripMenuItem_Click);
            // 
            // removeStageToolStripMenuItem
            // 
            this.removeStageToolStripMenuItem.Name = "removeStageToolStripMenuItem";
            this.removeStageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeStageToolStripMenuItem.Text = "Remove";
            this.removeStageToolStripMenuItem.Click += new System.EventHandler(this.removeStageToolStripMenuItem_Click);
            // 
            // ManageStagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 258);
            this.Controls.Add(this.dataGridViewStages);
            this.Controls.Add(this.menuStripManageStages);
            this.Name = "ManageStagesForm";
            this.Text = "ManageStages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageStagesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).EndInit();
            this.menuStripManageStages.ResumeLayout(false);
            this.menuStripManageStages.PerformLayout();
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
    }
}