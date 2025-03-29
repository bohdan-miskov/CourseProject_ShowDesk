using CourseProject_ShowDesk.Scripts.Enities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddEditZoneForm : MetroFramework.Forms.MetroForm
    {

        private bool isValid;

        private readonly Stage stage;

        private readonly Zone currentZone;

        //private Color color;

        public AddEditZoneForm(Stage stage, Zone zone=null)
        {
            InitializeComponent();

            isValid = false;
            this.stage = stage;
            
            if (zone != null)
            {
                this.currentZone = zone;
                PopulateFields();
            }
            else
            {
                this.currentZone = new Zone();
            }

            PopulateSeating();
        }

        private void TextBoxZoneName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownIncrease.Focus();
            }
        }

        private void TextBoxIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownStartPosition.Focus();
            }
        }

        private void NumericUpDownStartPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownEndPosition.Focus();
            }
        }

        private void NumericUpDownEndPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void NumericUpDownStartPosition_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownEndPosition.Value < numericUpDownStartPosition.Value)
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

        private void TextBoxIncrease_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            CreateZone();
            ZoneValidator validator = new ZoneValidator(stage.Zones);

            if (validator.Validate(currentZone,out string errorMessage))
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

        private void PopulateFields()
        {
            textBoxZoneName.Text = currentZone.Name;
            numericUpDownStartPosition.Minimum = 1;
            numericUpDownEndPosition.Maximum = stage.SeatList.Count;
            numericUpDownIncrease.Value = Convert.ToDecimal(currentZone.Increase);
            numericUpDownStartPosition.Value = currentZone.StartPosition;
            numericUpDownEndPosition.Value = currentZone.EndPosition;
            textBoxColor.Text = currentZone.GetColor().Name;
            buttonChangeColor.BackColor = currentZone.GetColor();
        }

        private void PopulateSeating()
        {
            foreach (Seat seat in stage.SeatList)
            {
                panelSeating.Controls.Add(seat.ToLabel());
            }
            foreach (DecorativeElement decor in stage.DecorList)
            {
                panelSeating.Controls.Add(decor.ToPanel());
            }
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
            foreach (Control control in panelSeating.Controls)
            {
                if(control is Label)
                {
                    int index = Convert.ToInt32(control.Text);
                    if (index>=startIndex && index<=endIndex)
                    {
                        control.BackColor = colorDialog.Color;
                    }
                    else
                    {
                        control.BackColor = new Zone().GetColor();
                    }
                }
            }
        }
        private void CreateZone()
        {
            currentZone.StartPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
            currentZone.EndPosition = Convert.ToInt32(numericUpDownEndPosition.Value);
            currentZone.Name = textBoxZoneName.Text;
            currentZone.Increase = Convert.ToDouble(numericUpDownIncrease.Value);
        }
        public Zone GetZone()
        {
            return currentZone;
        }

        public bool GetIsValid()
        {
            return isValid;
        }
    }
}

