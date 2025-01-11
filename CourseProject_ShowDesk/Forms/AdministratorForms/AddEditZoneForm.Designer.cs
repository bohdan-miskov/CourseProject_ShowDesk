namespace CourseProject_ShowDesk
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
            this.numericUpDownStartPosition = new System.Windows.Forms.NumericUpDown();
            this.groupBoxZone = new System.Windows.Forms.GroupBox();
            this.labelZoneName = new System.Windows.Forms.Label();
            this.labelEndPosition = new System.Windows.Forms.Label();
            this.textBoxZoneName = new System.Windows.Forms.TextBox();
            this.labelStartPosition = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownEndPosition = new System.Windows.Forms.NumericUpDown();
            this.labelIncrease = new System.Windows.Forms.Label();
            this.toolTipZone = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownIncrease = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).BeginInit();
            this.groupBoxZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrease)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownStartPosition
            // 
            this.numericUpDownStartPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartPosition.Location = new System.Drawing.Point(174, 102);
            this.numericUpDownStartPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStartPosition.Name = "numericUpDownStartPosition";
            this.numericUpDownStartPosition.Size = new System.Drawing.Size(168, 28);
            this.numericUpDownStartPosition.TabIndex = 19;
            this.numericUpDownStartPosition.ValueChanged += new System.EventHandler(this.numericUpDownStartPosition_ValueChanged);
            this.numericUpDownStartPosition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownStartPosition_KeyUp);
            // 
            // groupBoxZone
            // 
            this.groupBoxZone.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxZone.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.groupBoxZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxZone.Controls.Add(this.numericUpDownIncrease);
            this.groupBoxZone.Controls.Add(this.labelZoneName);
            this.groupBoxZone.Controls.Add(this.labelEndPosition);
            this.groupBoxZone.Controls.Add(this.textBoxZoneName);
            this.groupBoxZone.Controls.Add(this.labelStartPosition);
            this.groupBoxZone.Controls.Add(this.buttonAdd);
            this.groupBoxZone.Controls.Add(this.numericUpDownEndPosition);
            this.groupBoxZone.Controls.Add(this.labelIncrease);
            this.groupBoxZone.Controls.Add(this.numericUpDownStartPosition);
            this.groupBoxZone.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxZone.Location = new System.Drawing.Point(0, 63);
            this.groupBoxZone.Name = "groupBoxZone";
            this.groupBoxZone.Size = new System.Drawing.Size(368, 250);
            this.groupBoxZone.TabIndex = 23;
            this.groupBoxZone.TabStop = false;
            this.groupBoxZone.Text = "Zone";
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
            this.labelEndPosition.Location = new System.Drawing.Point(16, 143);
            this.labelEndPosition.Name = "labelEndPosition";
            this.labelEndPosition.Size = new System.Drawing.Size(109, 21);
            this.labelEndPosition.TabIndex = 22;
            this.labelEndPosition.Text = "End position";
            // 
            // textBoxZoneName
            // 
            this.textBoxZoneName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZoneName.Location = new System.Drawing.Point(174, 37);
            this.textBoxZoneName.Name = "textBoxZoneName";
            this.textBoxZoneName.Size = new System.Drawing.Size(168, 28);
            this.textBoxZoneName.TabIndex = 15;
            this.textBoxZoneName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // labelStartPosition
            // 
            this.labelStartPosition.AutoSize = true;
            this.labelStartPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelStartPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartPosition.Location = new System.Drawing.Point(16, 109);
            this.labelStartPosition.Name = "labelStartPosition";
            this.labelStartPosition.Size = new System.Drawing.Size(115, 21);
            this.labelStartPosition.TabIndex = 21;
            this.labelStartPosition.Text = "Start position";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(105, 186);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 42);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Save";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownEndPosition
            // 
            this.numericUpDownEndPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEndPosition.Location = new System.Drawing.Point(174, 136);
            this.numericUpDownEndPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEndPosition.Name = "numericUpDownEndPosition";
            this.numericUpDownEndPosition.Size = new System.Drawing.Size(168, 28);
            this.numericUpDownEndPosition.TabIndex = 20;
            this.numericUpDownEndPosition.ValueChanged += new System.EventHandler(this.numericUpDownEndPosition_ValueChanged);
            this.numericUpDownEndPosition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownEndPosition_KeyUp);
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
            // numericUpDownIncrease
            // 
            this.numericUpDownIncrease.DecimalPlaces = 1;
            this.numericUpDownIncrease.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownIncrease.Location = new System.Drawing.Point(174, 70);
            this.numericUpDownIncrease.Name = "numericUpDownIncrease";
            this.numericUpDownIncrease.Size = new System.Drawing.Size(168, 28);
            this.numericUpDownIncrease.TabIndex = 23;
            // 
            // AddEditZoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 313);
            this.Controls.Add(this.groupBoxZone);
            this.Name = "AddEditZoneForm";
            this.Text = "AddEditZone";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).EndInit();
            this.groupBoxZone.ResumeLayout(false);
            this.groupBoxZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrease)).EndInit();
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
    }
}