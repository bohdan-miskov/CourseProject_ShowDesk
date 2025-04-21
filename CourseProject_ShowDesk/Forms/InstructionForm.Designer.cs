namespace CourseProject_ShowDesk.Forms
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.tabControlInstruction = new System.Windows.Forms.TabControl();
            this.tabPageEntry = new System.Windows.Forms.TabPage();
            this.pictureBoxLogotype = new System.Windows.Forms.PictureBox();
            this.richTextBoxEntry = new System.Windows.Forms.RichTextBox();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.richTextBoxStartSettings = new System.Windows.Forms.RichTextBox();
            this.tabPageRoles = new System.Windows.Forms.TabPage();
            this.pictureBoxCashier = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdministrator = new System.Windows.Forms.PictureBox();
            this.pictureBoxDirector = new System.Windows.Forms.PictureBox();
            this.richTextBoxRoles = new System.Windows.Forms.RichTextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.tabControlInstruction.SuspendLayout();
            this.tabPageEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotype)).BeginInit();
            this.tabPageStart.SuspendLayout();
            this.tabPageRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdministrator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirector)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlInstruction
            // 
            this.tabControlInstruction.Controls.Add(this.tabPageEntry);
            this.tabControlInstruction.Controls.Add(this.tabPageStart);
            this.tabControlInstruction.Controls.Add(this.tabPageRoles);
            this.tabControlInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInstruction.Location = new System.Drawing.Point(20, 60);
            this.tabControlInstruction.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControlInstruction.Name = "tabControlInstruction";
            this.tabControlInstruction.SelectedIndex = 0;
            this.tabControlInstruction.Size = new System.Drawing.Size(860, 647);
            this.tabControlInstruction.TabIndex = 0;
            // 
            // tabPageEntry
            // 
            this.tabPageEntry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageEntry.Controls.Add(this.pictureBoxLogotype);
            this.tabPageEntry.Controls.Add(this.richTextBoxEntry);
            this.tabPageEntry.Location = new System.Drawing.Point(4, 30);
            this.tabPageEntry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPageEntry.Name = "tabPageEntry";
            this.tabPageEntry.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPageEntry.Size = new System.Drawing.Size(852, 613);
            this.tabPageEntry.TabIndex = 0;
            this.tabPageEntry.Text = "Entry";
            // 
            // pictureBoxLogotype
            // 
            this.pictureBoxLogotype.Image = global::CourseProject_ShowDesk.Properties.Resources.Logotype;
            this.pictureBoxLogotype.Location = new System.Drawing.Point(513, 138);
            this.pictureBoxLogotype.Name = "pictureBoxLogotype";
            this.pictureBoxLogotype.Size = new System.Drawing.Size(336, 331);
            this.pictureBoxLogotype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogotype.TabIndex = 1;
            this.pictureBoxLogotype.TabStop = false;
            // 
            // richTextBoxEntry
            // 
            this.richTextBoxEntry.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxEntry.Location = new System.Drawing.Point(6, 5);
            this.richTextBoxEntry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBoxEntry.Name = "richTextBoxEntry";
            this.richTextBoxEntry.Size = new System.Drawing.Size(506, 603);
            this.richTextBoxEntry.TabIndex = 0;
            this.richTextBoxEntry.Text = resources.GetString("richTextBoxEntry.Text");
            // 
            // tabPageStart
            // 
            this.tabPageStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageStart.Controls.Add(this.richTextBoxStartSettings);
            this.tabPageStart.Location = new System.Drawing.Point(4, 30);
            this.tabPageStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPageStart.Size = new System.Drawing.Size(852, 613);
            this.tabPageStart.TabIndex = 1;
            this.tabPageStart.Text = "Start";
            // 
            // richTextBoxStartSettings
            // 
            this.richTextBoxStartSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStartSettings.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStartSettings.Location = new System.Drawing.Point(6, 5);
            this.richTextBoxStartSettings.Name = "richTextBoxStartSettings";
            this.richTextBoxStartSettings.Size = new System.Drawing.Size(840, 603);
            this.richTextBoxStartSettings.TabIndex = 0;
            this.richTextBoxStartSettings.Text = resources.GetString("richTextBoxStartSettings.Text");
            // 
            // tabPageRoles
            // 
            this.tabPageRoles.Controls.Add(this.pictureBoxCashier);
            this.tabPageRoles.Controls.Add(this.pictureBoxAdministrator);
            this.tabPageRoles.Controls.Add(this.pictureBoxDirector);
            this.tabPageRoles.Controls.Add(this.richTextBoxRoles);
            this.tabPageRoles.Location = new System.Drawing.Point(4, 30);
            this.tabPageRoles.Name = "tabPageRoles";
            this.tabPageRoles.Size = new System.Drawing.Size(852, 613);
            this.tabPageRoles.TabIndex = 2;
            this.tabPageRoles.Text = "Roles";
            this.tabPageRoles.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCashier
            // 
            this.pictureBoxCashier.Image = global::CourseProject_ShowDesk.Properties.Resources.Cashier;
            this.pictureBoxCashier.Location = new System.Drawing.Point(684, 428);
            this.pictureBoxCashier.Name = "pictureBoxCashier";
            this.pictureBoxCashier.Size = new System.Drawing.Size(151, 182);
            this.pictureBoxCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCashier.TabIndex = 4;
            this.pictureBoxCashier.TabStop = false;
            // 
            // pictureBoxAdministrator
            // 
            this.pictureBoxAdministrator.Image = global::CourseProject_ShowDesk.Properties.Resources.Administrator;
            this.pictureBoxAdministrator.Location = new System.Drawing.Point(684, 240);
            this.pictureBoxAdministrator.Name = "pictureBoxAdministrator";
            this.pictureBoxAdministrator.Size = new System.Drawing.Size(151, 182);
            this.pictureBoxAdministrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdministrator.TabIndex = 3;
            this.pictureBoxAdministrator.TabStop = false;
            // 
            // pictureBoxDirector
            // 
            this.pictureBoxDirector.Image = global::CourseProject_ShowDesk.Properties.Resources.Director;
            this.pictureBoxDirector.Location = new System.Drawing.Point(684, 52);
            this.pictureBoxDirector.Name = "pictureBoxDirector";
            this.pictureBoxDirector.Size = new System.Drawing.Size(151, 182);
            this.pictureBoxDirector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDirector.TabIndex = 2;
            this.pictureBoxDirector.TabStop = false;
            // 
            // richTextBoxRoles
            // 
            this.richTextBoxRoles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxRoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxRoles.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxRoles.Name = "richTextBoxRoles";
            this.richTextBoxRoles.Size = new System.Drawing.Size(658, 613);
            this.richTextBoxRoles.TabIndex = 1;
            this.richTextBoxRoles.Text = resources.GetString("richTextBoxRoles.Text");
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "UA",
            "EN"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(821, 55);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(55, 29);
            this.comboBoxLanguage.TabIndex = 1;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 727);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.tabControlInstruction);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "InstructionForm";
            this.Text = "InstructionForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InstructionForm_KeyDown);
            this.tabControlInstruction.ResumeLayout(false);
            this.tabPageEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotype)).EndInit();
            this.tabPageStart.ResumeLayout(false);
            this.tabPageRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdministrator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInstruction;
        private System.Windows.Forms.TabPage tabPageEntry;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.RichTextBox richTextBoxEntry;
        private System.Windows.Forms.RichTextBox richTextBoxStartSettings;
        private System.Windows.Forms.TabPage tabPageRoles;
        private System.Windows.Forms.RichTextBox richTextBoxRoles;
        private System.Windows.Forms.PictureBox pictureBoxDirector;
        private System.Windows.Forms.PictureBox pictureBoxCashier;
        private System.Windows.Forms.PictureBox pictureBoxAdministrator;
        private System.Windows.Forms.PictureBox pictureBoxLogotype;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}