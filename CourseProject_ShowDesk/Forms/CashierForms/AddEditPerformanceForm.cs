using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class AddEditPerformanceForm : MetroFramework.Forms.MetroForm
    {

        private readonly List<Stage> stages;
        private readonly List<Performance> performances;

        private bool isValid;

        private readonly Performance currentPerformance;

        public AddEditPerformanceForm(List<Stage> stages, List<Performance> performances, Performance currentPerformance=null)
        {
            InitializeComponent();

            this.stages = stages;
            this.performances = performances;

            dateTimePickerPerfomanceDate.MinDate = DateTime.Now.Date;
            dateTimePickerDuration.Value = (DateTime.Today)+(AppConstants.InitialPerformanceDuration);

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            PopulateComboBox();

            isValid = false;


            if(currentPerformance != null)
            {
                this.currentPerformance = currentPerformance;
                PopulateFields();
            }
            else
            {
                this.currentPerformance = new Performance(new PerformanceBaseService());
            }
        }

        private void DateTimePickerPerfomanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPerformanceName.Focus();
            }
        }
        private void TextBoxPerformanceName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxBaseTicketPrice.Focus();
            }
        }
        private void TextBoxBaseTicketPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxStage.Focus();
            }
        }
        private void ComboBoxStage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.Focus();
            }
        }

        private void TextBoxBaseTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            CreatePerformance();
            PerformanceValidator validator = new PerformanceValidator(performances);
            if (validator.Validate(currentPerformance,out string errorMessage))
            {
                isValid = true;
                this.Close();
            }
            MessageBox.Show(
                                errorMessage,
                                "Performance error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
                buttonSave.Enabled = false;
            }
            else
            {
                comboBoxStage.SelectedIndex = 0;
            }
        }
        private void PopulateFields()
        {
            dateTimePickerPerfomanceDate.Value = currentPerformance.PerformanceDateTime;
            textBoxPerformanceName.Text = currentPerformance.Name;
            textBoxBaseTicketPrice.Text = Convert.ToString(currentPerformance.Price);
            dateTimePickerDuration.Value = DateTime.Today + currentPerformance.Duration;

            //textBoxBaseTicketPrice.Enabled = false;
            //comboBoxStage.Enabled = false;

            PopulateStageComboBox();
        }
        private void PopulateStageComboBox()
        {
            foreach (Stage stage in stages)
            {
                comboBoxStage.Items.Add(stage.Name);
            }

            if (stages.Count == 0)
            {
                comboBoxStage.Enabled = false;
                buttonSave.Enabled = false;
            }
            else
            {
                comboBoxStage.SelectedIndex = GetIndexOfStage();
            }
        }
        private int GetIndexOfStage()
        {
            for (int i = 0; i < stages.Count; i++)
            {
                if (stages[i].Id == currentPerformance.StageId)
                {
                    return i;
                }
            }
            return -1;
        }
        private void CreatePerformance()
        {
            //Performance currentPerformance = new Performance(new PerformanceBaseService());
            currentPerformance.Name= textBoxPerformanceName.Text;
            currentPerformance.PerformanceDateTime= dateTimePickerPerfomanceDate.Value;
            currentPerformance.Price = Convert.ToDouble(textBoxBaseTicketPrice.Text);
            currentPerformance.Duration= new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);
            if (currentPerformance.StageId != stages[comboBoxStage.SelectedIndex].Id)
            {
                currentPerformance.AvailablePositions = stages[comboBoxStage.SelectedIndex].GetPositions();
            }
            currentPerformance.StageId = stages[comboBoxStage.SelectedIndex].Id;
        }

        //private bool ValidateOfPerformance()
        //{
        //    if (!ValidateOfPerformanceName()) return false;
        //    if (!ValidateOfPerformancePrice()) return false;
        //    if (!ValidateOfPerformanceDate()) return false;
        //    if (!ValidateOfPerformanceDuration()) return false;
        //    if (!ValidateIntersectsOfPerformances()) return false;

        //    return true;
        //}

        //private bool ValidateOfPerformanceName()
        //{
        //    if (!ParametersValidator.NameValidator(textBoxPerformanceName.Text))
        //    {
        //        MessageBox.Show(
        //                        "There was an error in the name of the Performance: the name must be more than two characters long",
        //                        "Performance name error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //        textBoxPerformanceName.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        //private bool ValidateOfPerformancePrice()
        //{
        //    if (!ParametersValidator.DoubleValidator(textBoxBaseTicketPrice.Text))
        //    {
        //        MessageBox.Show(
        //                        "The base price of the ticket must be entered in the format 0.000, cannot be negative or empty",
        //                        "Ticket price error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //        textBoxBaseTicketPrice.Focus();
        //        return false;
        //    }

        //    return true;

        //}

        //private bool ValidateOfPerformanceDate()
        //{
        //    if (dateTimePickerPerfomanceDate.Value < DateTime.Now)
        //    {
        //        MessageBox.Show(
        //                        "Performance date and time cannot be in the past.",
        //                        "Performance date error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //        dateTimePickerPerfomanceDate.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        //private bool ValidateOfPerformanceDuration()
        //{
        //    TimeSpan currentDuration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);
        //    if (currentDuration<=TimeSpan.Zero || currentDuration>AppConstants.MaxDuration)
        //    {
        //        MessageBox.Show(
        //                        $"There was an error in the duration of the Performance: The duration cannot be negative or exceed the {AppConstants.MaxDuration.ToString()}",
        //                        "Performance duration error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);

        //        dateTimePickerDuration.Focus();

        //        return false;
        //    }

        //    return true;
        //}

        //private bool ValidateIntersectsOfPerformances()
        //{
        //    string intersectsPerformanceName = FindIntersectionPerformance();
        //    if (intersectsPerformanceName != null)
        //    {
        //        MessageBox.Show(
        //                       $"The screening of the current performance is interspersed with the screening of the {intersectsPerformanceName} performance in {stages[comboBoxStage.SelectedIndex].Name}",
        //                       "Performance error",
        //                       MessageBoxButtons.OK,
        //                       MessageBoxIcon.Error);
        //        comboBoxStage.Focus();
        //        return false;
        //    }

        //    return true;

        //}

        //private string FindIntersectionPerformance()
        //{
        //    DateTime currentDate = dateTimePickerPerfomanceDate.Value;

        //    foreach (Performance performance in performances)
        //    {
        //        if (performance.StageId == stages[comboBoxStage.SelectedIndex].Id)
        //        {
        //            if ((currentDate - performance.PerformanceDateTime).Days < 1)
        //            {
        //                if(IsIntersectionOfPerformances(currentDate, performance))
        //                {
        //                    return performance.Name;
        //                }
        //            }
        //        }
        //    }

        //    return null;
        //}

        //private bool IsIntersectionOfPerformances(DateTime currentDate, Performance performance)
        //{
        //    double currentTimeDifference=0;
        //    double minTimeDifference=0;

        //    if (currentDate > performance.PerformanceDateTime)
        //    {
        //        currentTimeDifference = (currentDate - performance.PerformanceDateTime).TotalMinutes;
        //        minTimeDifference = performance.Duration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
        //    }
        //    else
        //    {
        //        currentTimeDifference = (performance.PerformanceDateTime - currentDate).TotalMinutes;
        //        TimeSpan currentDuration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);
        //        minTimeDifference = currentDuration.TotalMinutes + AppConstants.MinBreakBetweenPerformance.TotalMinutes;
        //    }

        //    if (currentTimeDifference < minTimeDifference)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public Performance GetPerformance()
        {
            return currentPerformance;
        }

        public bool GetIsValid()
        {
            return isValid;
        }
    }
}
