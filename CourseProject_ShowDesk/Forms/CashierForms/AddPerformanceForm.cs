using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
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

            dateTimePickerPerfomanceDate.MinDate = DateTime.Now.Date;
            dateTimePickerDuration.Value = (DateTime.Today)+(AppConstants.InitialPerformanceDuration);

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            PopulateComboBox();

            isValid = false;
            newPerformance = new Performance();
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

        private void textBoxBaseTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateOfPerformance())
            {
                isValid = true;

                AddPerformance();

                this.Close();
            }
        }

        private void PopulateComboBox()
        {
            comboBoxStage.Items.Clear();

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

        private void AddPerformance()
        {
            DateTime performanceDateTime = dateTimePickerPerfomanceDate.Value;
            string performanceName = textBoxPerformanceName.Text;
            double baseTicketPrice = Convert.ToDouble(textBoxBaseTicketPrice.Text);
            int stageIndex = stages[comboBoxStage.SelectedIndex].Index;
            TimeSpan duration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute,0);

            newPerformance = new Performance(performanceName, baseTicketPrice, performanceDateTime, duration, stageIndex);
        }

        private bool ValidateOfPerformance()
        {
            if (!ValidateOfPerformanceName()) return false;
            if (!ValidateOfPerformancePrice()) return false;
            if (!ValidateOfPerformanceDate()) return false;
            if (!ValidateOfPerformanceDuration()) return false;
            if (!ValidateIntersectsOfPerformances()) return false;

            return true;
        }

        private bool ValidateOfPerformanceName()
        {
            if (!ParametersValidator.NameValidator(textBoxPerformanceName.Text))
            {
                MessageBox.Show(
                                "There was an error in the name of the Performance: the name must be more than two characters long",
                                "Performance name error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxPerformanceName.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfPerformancePrice()
        {
            if (!ParametersValidator.DoubleValidator(textBoxBaseTicketPrice.Text))
            {
                MessageBox.Show(
                                "The base price of the ticket must be entered in the format 0.000, cannot be negative or empty",
                                "Ticket price error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxBaseTicketPrice.Focus();
                return false;
            }

            return true;

        }

        private bool ValidateOfPerformanceDate()
        {
            if (dateTimePickerPerfomanceDate.Value < DateTime.Now)
            {
                MessageBox.Show(
                                "Performance date and time cannot be in the past.",
                                "Performance date error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                dateTimePickerPerfomanceDate.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfPerformanceDuration()
        {
            TimeSpan currentDuration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);
            if (currentDuration<=TimeSpan.Zero || currentDuration>AppConstants.MaxDuration)
            {
                MessageBox.Show(
                                $"There was an error in the duration of the Performance: The duration cannot be negative or exceed the {AppConstants.MaxDuration.ToString()}",
                                "Performance duration error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                dateTimePickerDuration.Focus();

                return false;
            }

            return true;
        }

        private bool ValidateIntersectsOfPerformances()
        {
            string intersectsPerformanceName = FindIntersectionPerformance();
            if (intersectsPerformanceName != null)
            {
                MessageBox.Show(
                               $"The screening of the current performance is interspersed with the screening of the {intersectsPerformanceName} performance in {stages[comboBoxStage.SelectedIndex].Name}",
                               "Performance error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                comboBoxStage.Focus();
                return false;
            }

            return true;

        }

        private string FindIntersectionPerformance()
        {
            DateTime currentDate = dateTimePickerPerfomanceDate.Value;

            foreach (Performance performance in performances)
            {
                if (performance.StageIndex == stages[comboBoxStage.SelectedIndex].Index)
                {
                    if ((currentDate - performance.PerformanceDateTime).Days < 1)
                    {
                        if(IsIntersectionOfPerformances(currentDate, performance))
                        {
                            return performance.Name;
                        }
                    }
                }
            }

            return null;
        }

        private bool IsIntersectionOfPerformances(DateTime currentDate, Performance performance)
        {
            double currentTimeDifference=0;
            double minTimeDifference=0;

            if (currentDate > performance.PerformanceDateTime)
            {
                currentTimeDifference = (currentDate - performance.PerformanceDateTime).TotalMinutes;
                minTimeDifference = performance.Duration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
            }
            else
            {
                currentTimeDifference = (performance.PerformanceDateTime - currentDate).TotalMinutes;
                TimeSpan currentDuration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);
                minTimeDifference = currentDuration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
            }

            if (currentTimeDifference < minTimeDifference)
            {
                return true;
            }

            return false;
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
