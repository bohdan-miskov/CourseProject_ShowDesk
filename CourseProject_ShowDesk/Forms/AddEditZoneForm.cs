using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class AddEditZoneForm : MetroFramework.Forms.MetroForm
    {

        private bool isValid;

        private Stage stage;

        private int zoneIndex;

        public AddEditZoneForm(Stage stage, int? zoneIndex)
        {
            InitializeComponent();

            isValid = false;
            this.stage = stage;


            if (zoneIndex != null)
            {
                this.zoneIndex = Convert.ToInt32(zoneIndex);
                PopulateFields();
            }
        }

        private void PopulateFields()
        {
            textBoxZoneName.Text = stage.GetZone(zoneIndex).Name;
            textBoxIncrease.Text = Convert.ToString(stage.GetZone(zoneIndex).Increase);
            numericUpDownStartPosition.Value = stage.GetZone(zoneIndex).StartPosition;
            numericUpDownEndPosition.Value = stage.GetZone(zoneIndex).EndPosition;
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxIncrease.Focus();
        }

        private void textBoxIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDownStartPosition.Focus();
        }

        private void numericUpDownStartPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDownEndPosition.Focus();
        }

        private void numericUpDownEndPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAdd.Focus();
        }

        private void numericUpDownStartPosition_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEndPosition.Minimum = numericUpDownStartPosition.Value;
        }

        private void numericUpDownEndPosition_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownStartPosition.Maximum = numericUpDownEndPosition.Value;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateOfZone())
            {
                if (AddZone())
                {
                    isValid = true;

                    this.Close();
                }
            }
        }

        private bool AddZone()
        {
            string zoneName = textBoxZoneName.Text;
            double increase = Convert.ToDouble(textBoxIncrease.Text);
            int startPosition = Convert.ToInt32(numericUpDownStartPosition.Value);
            int endPosition = Convert.ToInt32(numericUpDownEndPosition.Value);

            if (!stage.AddZone(new Zone(zoneName, increase, startPosition, endPosition)))
            {
                MessageBox.Show(this,
                "The starting position cannot be larger than the final position and the range of positions in the new sector cannot intersect with any range of positions in another sector of the hall",
                "Range of positions error",
                MessageBoxButtons.OK);
                numericUpDownStartPosition.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfZone()
        {
            if (!ParametersValidator.NameValidator(textBoxZoneName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the zone: the name must be more than two characters long",
                                "Name zone error",
                                MessageBoxButtons.OK);
                textBoxZoneName.Focus();
                return false;
            }

            if (!ParametersValidator.DoubleValidator(textBoxIncrease.Text))
            {
                MessageBox.Show(this,
                                "The surcharge must be entered in the format 0.000, cannot be negative or empty",
                                "Increase zone error",
                                MessageBoxButtons.OK);
                textBoxIncrease.Focus();
                return false;
            }
            return true;
        }

        public Stage GetStage()
        {
            return stage;
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        private void textBoxIncrease_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }
    }
}

