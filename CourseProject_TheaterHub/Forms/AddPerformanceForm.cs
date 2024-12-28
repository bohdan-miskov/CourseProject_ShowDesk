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

namespace CourseProject_TheaterHub
{
    public partial class AddPerformanceForm : MetroFramework.Forms.MetroForm
    {

        private List<Stage> stages;
        private List<Performance> performances;

        private bool isValid;

        private Performance newPerformance;

        public AddPerformanceForm(List<Stage> stages, List<Performance> performances)
        {
            InitializeComponent();

            this.stages = stages;
            this.performances = performances;

            PopulateComboBox();

            isValid = false;
            newPerformance = new Performance();

        }


        private void PopulateComboBox()
        {
            foreach (Stage stage in stages)
            {
                comboBoxStage.Items.Add(stage.Name);
            }

            if (stages.Count == 0)
            {
                comboBoxStage.Enabled = false;
                buttonAdd.Enabled = false;
            }
            else
            {
                comboBoxStage.SelectedIndex = 0;
            }
        }

        private bool NameValidator(string name)
        {
            if (name.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PriceValidator(string increase)
        {
            double currentPrice;

            if (increase.Length == 0)
            {
                return false;
            }

            try
            {
                currentPrice = Convert.ToDouble(increase);
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }

            if (currentPrice < 0)
            {
                return false;
            }

            return true;
        }

        private void dateTimePickerPerfomanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxName.Focus();
            }
        }
        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxBaseTicketPrice.Focus();
            }
        }
        private void textBoxBaseTicketPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxStage.Focus();
            }
        }
        private void comboBoxStage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!NameValidator(textBoxName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the Performance: the name must be more than two characters long",
                                "Performance name error",
                                MessageBoxButtons.OK);
                textBoxName.Focus();
                return;
            }

            if (!PriceValidator(textBoxBaseTicketPrice.Text))
            {
                MessageBox.Show(this,
                                "The base price of the ticket must be entered in the format 0.000, cannot be negative or empty",
                                "Ticket price error",
                                MessageBoxButtons.OK);
                textBoxBaseTicketPrice.Focus();
                return;
            }

            isValid = true;
            newPerformance = new Performance(dateTimePickerPerfomanceDate.Value, 
                textBoxName.Text, 
                Convert.ToDouble(textBoxBaseTicketPrice.Text), 
                stages[comboBoxStage.SelectedIndex].Index);

            this.Close();
        }

        public Performance GetNewPerformance()
        {
            return newPerformance;
        }

        public bool GetIsValid()
        {
            return isValid;
        }

    }
}
