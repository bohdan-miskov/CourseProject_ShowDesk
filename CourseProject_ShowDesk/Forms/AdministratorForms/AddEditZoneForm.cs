using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddEditZoneForm : MetroFramework.Forms.MetroForm
    {
        private bool logOut;
        private bool isValid;

        private readonly List<Zone> zones;

        private readonly Zone currentZone;

        private readonly SeatingManager seatingManager;
        private readonly CanvasController canvasController;

        public AddEditZoneForm(Employee userAccount, Stage stage, Zone zone = null)
        {
            InitializeComponent();

            this.MouseWheel += PanelSeating_MouseWheel;

            isValid = false;
            logOut = false;
            this.zones = stage.Zones;
            this.seatingManager = new SeatingManager(panelSeating, stage?.SeatList, stage?.DecorList);
            this.canvasController = new CanvasController(panelSeating, panelViewport);

            labelAccountName.Text = userAccount.FullName;

            if (zone != null)
            {
                this.currentZone = zone;
                PopulateFields();
            }
            else this.currentZone = new Zone();

            PopulateComponents();

            FormConfigurator.ConfigureForm(this, true);
        }

        private void TextBoxZoneName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericUpDownIncrease.Focus();
        }

        private void TextBoxIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericUpDownStartPosition.Focus();
        }

        private void NumericUpDownStartPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericUpDownEndPosition.Focus();
        }

        private void NumericUpDownEndPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAdd.Focus();
        }

        private void NumericUpDownStartPosition_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEndPosition.Value < numericUpDownStartPosition.Value)
            {
                numericUpDownEndPosition.Value = numericUpDownStartPosition.Value;
            }
        }

        private void NumericUpDownEndPosition_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEndPosition.Value < numericUpDownStartPosition.Value)
            {
                numericUpDownStartPosition.Value = numericUpDownEndPosition.Value;
            }
        }
        private void PanelSeating_MouseWheel(object sender, MouseEventArgs e)
        {
            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartScaleCanvas(e, useControl);
        }
        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SaveZone();
        }

        private void PopulateFields()
        {
            textBoxZoneName.Text = currentZone.Name;
            numericUpDownIncrease.Value = Convert.ToDecimal(currentZone.Increase);
            numericUpDownStartPosition.Value = currentZone.StartPosition;
            numericUpDownEndPosition.Value = currentZone.EndPosition;
            textBoxColor.Text = currentZone.GetColor().Name;
            buttonChangeColor.BackColor = currentZone.GetColor();
        }

        private void PopulateComponents()
        {
            numericUpDownStartPosition.Minimum = 1;
            numericUpDownEndPosition.Maximum = seatingManager.SeatList.Count;

            seatingManager.PopulateSeating();
        }
        private void ChangeColor()
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentZone.SetColor(colorDialog.Color);
                textBoxColor.Text = currentZone.GetColor().Name;
                buttonChangeColor.BackColor = currentZone.GetColor();

                SeatingColorChange();
            }
        }
        private void SeatingColorChange()
        {
            int startIndex = Convert.ToInt32(numericUpDownStartPosition.Value);
            int endIndex = Convert.ToInt32(numericUpDownEndPosition.Value);
            foreach (Control control in panelSeating.Controls.OfType<Label>().ToList())
            {
                int position = seatingManager.GetCurrentSeatPosition(control);
                if (position >= startIndex && position <= endIndex)
                    control.BackColor = colorDialog.Color;
                else control.BackColor = seatingManager.GetSeatColorByControl(control);
            }
        }
        private void CreateZone()
        {
            currentZone.StartPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
            currentZone.EndPosition = Convert.ToInt32(numericUpDownEndPosition.Value);
            currentZone.Name = textBoxZoneName.Text;
            currentZone.Increase = Convert.ToDouble(numericUpDownIncrease.Value);
        }
        private void SaveZone()
        {
            CreateZone();
            ZoneValidator validator = new ZoneValidator(zones);

            if (validator.Validate(currentZone, out string errorMessage))
            {
                isValid = true;

                this.Close();
            }
            else MessageBox.Show(
                                 errorMessage,
                                 "Zone error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
        }
        public Zone GetZone()
        {
            return currentZone;
        }
        private void LogOut()
        {
            logOut = true;
            this.Close();
        }

        public bool GetLogOut()
        {
            return logOut;
        }

        public bool GetIsValid()
        {
            return isValid;
        }
    }
}

