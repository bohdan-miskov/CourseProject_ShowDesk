using CourseProject_ShowDesk.Scripts.Enities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class AddEditZoneForm : MetroFramework.Forms.MetroForm
    {

        private bool isValid;

        private Stage stage;

        private int zoneIndex=-1;

        private Color color = Color.LightBlue;

        public AddEditZoneForm(Stage stage, int? zoneIndex)
        {
            InitializeComponent();

            isValid = false;
            this.stage = stage;

            numericUpDownStartPosition.Minimum = 1;
            numericUpDownEndPosition.Maximum = stage.SeatList.Count;
            textBoxColor.Text = color.Name;

            if (zoneIndex != null)
            {
                this.zoneIndex = Convert.ToInt32(zoneIndex);
                PopulateFields();
            }

            PopulateSeating();
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownIncrease.Focus();
            }
        }

        private void textBoxIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownStartPosition.Focus();
            }
        }

        private void numericUpDownStartPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownEndPosition.Focus();
            }
        }

        private void numericUpDownEndPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void numericUpDownStartPosition_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownEndPosition.Value < numericUpDownStartPosition.Value)
            {
                numericUpDownEndPosition.Value = numericUpDownStartPosition.Value;
            }
        }

        private void numericUpDownEndPosition_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEndPosition.Value < numericUpDownStartPosition.Value)
            {
                numericUpDownStartPosition.Value = numericUpDownEndPosition.Value;
            }
        }

        private void textBoxIncrease_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateOfZone())
            {
                AddZone();

                isValid = true;

                this.Close();
            }
        }

        private void PopulateFields()
        {
            textBoxZoneName.Text = stage.GetZone(zoneIndex).Name;
            numericUpDownIncrease.Value = Convert.ToDecimal(stage.GetZone(zoneIndex).Increase);
            numericUpDownStartPosition.Value = stage.GetZone(zoneIndex).StartPosition;
            numericUpDownEndPosition.Value = stage.GetZone(zoneIndex).EndPosition;
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
                SeatinColorChange();
            }
        }

        private void SeatinColorChange()
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
                        control.BackColor = new Zone().Color;
                    }
                }
            }

        }

        private void AddZone()
        {
            int startPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
            int endPosition = Convert.ToInt32(numericUpDownEndPosition.Value);
            string zoneName = textBoxZoneName.Text;
            double increase = Convert.ToDouble(numericUpDownIncrease.Value);

            Zone newZone = new Zone(zoneName, increase, startPosition, endPosition, color);

            AddZoneForSeats(startPosition-1, endPosition-1, newZone);

            if (zoneIndex != -1)
            {
                stage.Zones[zoneIndex] = newZone;
            }
            else
            {
                stage.AddZone(newZone);
            }
        }

        private bool ValidateOfZone()
        {
            if (!ValidateOfZoneName()) return false;
            if (!ValidateOfZoneIncrease()) return false;
            if (!ValidateOfZonePositions()) return false;

            return true;
        }

        private bool ValidateOfZoneName()
        {
            if (!ParametersValidator.NameValidator(textBoxZoneName.Text))
            {
                MessageBox.Show(
                                "There was an error in the name of the zone: the name must be more than two characters long",
                                "Name zone error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxZoneName.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfZoneIncrease()
        {
            if (!ParametersValidator.DoubleValidator(numericUpDownIncrease.Value.ToString()))
            {
                MessageBox.Show(
                                "The surcharge must be entered in the format 0.000, cannot be negative or empty",
                                "Increase zone error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                numericUpDownIncrease.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfZonePositions()
        {
            int startPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
            int endPosition = Convert.ToInt32(numericUpDownEndPosition.Value);

            if (!stage.CheckZonePositions(startPosition, endPosition, zoneIndex))
            {
                MessageBox.Show(
                "The starting position cannot be larger than the final position and the range of positions in the new sector cannot intersect with any range of positions in another sector of the hall",
                "Range of positions error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                numericUpDownStartPosition.Focus();
                return false;
            }

            return true;
        }

        private void AddZoneForSeats(int startIndex, int endIndex, Zone zone)
        {
            for(int i=startIndex; i<=endIndex; i++)
            {
                stage.SeatList[i].CurrentZone = zone;
            }
        }

        public Stage GetStage()
        {
            return stage;
        }

        public bool GetIsValid()
        {
            return isValid;
        }
    }
}

