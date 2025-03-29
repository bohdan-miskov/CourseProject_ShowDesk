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

        private Color color;

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

            color = currentZone.GetColor();
            numericUpDownStartPosition.Minimum = 1;
            numericUpDownEndPosition.Maximum = stage.SeatList.Count;
            textBoxColor.Text = color.Name;

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
            numericUpDownIncrease.Value = Convert.ToDecimal(currentZone.Increase);
            numericUpDownStartPosition.Value = currentZone.StartPosition;
            numericUpDownEndPosition.Value = currentZone.EndPosition;
            textBoxColor.Text = currentZone.GetColor().Name;
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
                color = colorDialog.Color;
                textBoxColor.Text = color.Name;
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
            //AddZoneForSeats(startPosition-1, endPosition-1, newZone);
            currentZone.StartPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
            currentZone.EndPosition = Convert.ToInt32(numericUpDownEndPosition.Value);
            currentZone.Name = textBoxZoneName.Text;
            currentZone.Increase = Convert.ToDouble(numericUpDownIncrease.Value);
            currentZone.SetColor(color);
        }
        //private bool ValidateOfZone()
        //{
        //    if (!ValidateOfZoneName()) return false;
        //    if (!ValidateOfZoneIncrease()) return false;
        //    if (!ValidateOfZonePositions()) return false;

        //    return true;
        //}

        //private bool ValidateOfZoneName()
        //{
        //    if (!ParametersValidator.NameValidator(textBoxZoneName.Text))
        //    {
        //        MessageBox.Show(
        //                        "There was an error in the name of the zone: the name must be more than two characters long",
        //                        "Name zone error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //        textBoxZoneName.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        //private bool ValidateOfZoneIncrease()
        //{
        //    if (!ParametersValidator.DoubleValidator(numericUpDownIncrease.Value.ToString()))
        //    {
        //        MessageBox.Show(
        //                        "The surcharge must be entered in the format 0.000, cannot be negative or empty",
        //                        "Increase zone error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //        numericUpDownIncrease.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        //private bool ValidateOfZonePositions()
        //{
        //    int startPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
        //    int endPosition = Convert.ToInt32(numericUpDownEndPosition.Value);

        //    if (!stage.CheckZonePositions(startPosition, endPosition, currentZone))
        //    {
        //        MessageBox.Show(
        //        "The starting position cannot be larger than the final position and the range of positions in the new sector cannot intersect with any range of positions in another sector of the hall",
        //        "Range of positions error",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Error);
        //        numericUpDownStartPosition.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        //private void AddZoneForSeats(int startIndex, int endIndex, Zone zone)
        //{
        //    for(int i=startIndex; i<=endIndex; i++)
        //    {
        //        stage.SeatList[i].CurrentZone = zone;
        //    }
        //}

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

