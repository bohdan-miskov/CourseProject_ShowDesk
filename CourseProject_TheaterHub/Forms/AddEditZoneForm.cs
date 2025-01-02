using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Collections.Specialized.BitVector32;

namespace CourseProject_TheaterHub
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

            
            if(zoneIndex!=null)
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
            if (!ParametersValidator.NameValidator(textBoxZoneName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the zone: the name must be more than two characters long",
                                "Name zone error",
                                MessageBoxButtons.OK);
                textBoxZoneName.Focus();
                return;
            }

            if (!ParametersValidator.DoubleValidator(textBoxIncrease.Text))
            {
                MessageBox.Show(this,
                                "The surcharge must be entered in the format 0.000, cannot be negative or empty",
                                "Increase zone error",
                                MessageBoxButtons.OK);
                textBoxIncrease.Focus();
                return;
            }

            if (!stage.AddZone(new Zone(textBoxZoneName.Text,
                Convert.ToDouble(textBoxIncrease.Text),
                Convert.ToInt32(numericUpDownStartPosition.Value),
                Convert.ToInt32(numericUpDownEndPosition.Value))))
            {
                MessageBox.Show(this,
                "The starting position cannot be larger than the final position and the range of positions in the new sector cannot intersect with any range of positions in another sector of the hall",
                "Range of positions error",
                MessageBoxButtons.OK);
                numericUpDownStartPosition.Focus();
                return;
            }

            isValid = true;

            this.Close();
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

