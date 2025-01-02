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

        
        private void dateTimePickerPerfomanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPerformanceName.Focus();
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
            if (!ParametersValidator.NameValidator(textBoxPerformanceName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the Performance: the name must be more than two characters long",
                                "Performance name error",
                                MessageBoxButtons.OK);
                textBoxPerformanceName.Focus();
                return;
            }

            if (!ParametersValidator.DoubleValidator(textBoxBaseTicketPrice.Text))
            {
                MessageBox.Show(this,
                                "The base price of the ticket must be entered in the format 0.000, cannot be negative or empty",
                                "Ticket price error",
                                MessageBoxButtons.OK);
                textBoxBaseTicketPrice.Focus();
                return;
            }

            isValid = true;
            DateTime performanceDate = dateTimePickerPerfomanceDate.Value;
            DateTime performanceTime =dateTimePickerPerformanceTime.Value;
            DateTime performanceDateTime = performanceDate.Add(performanceTime.TimeOfDay);
            string performanceName = textBoxPerformanceName.Text;
            double baseTicketPrice = Convert.ToDouble(textBoxBaseTicketPrice.Text);
            int stageIndex = stages[comboBoxStage.SelectedIndex].Index;

            newPerformance = new Performance(performanceDateTime, performanceName, baseTicketPrice, stageIndex);

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

        private void textBoxBaseTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }
    }
}
