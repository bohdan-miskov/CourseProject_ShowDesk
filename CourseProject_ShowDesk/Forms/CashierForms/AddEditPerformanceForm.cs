using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class AddEditPerformanceForm : MetroFramework.Forms.MetroForm
    {

        private readonly List<Stage> stages;
        private readonly List<Performance> performances;
        private readonly Performance currentPerformance;

        private readonly DateTime defaultDate = new DateTime(1900, 1, 1);
        private readonly bool isFilterFunction;
        private bool isValid;
        private bool logOut;

        public AddEditPerformanceForm(Employee userAccount, List<Stage> stages, List<Performance> performances, Performance currentPerformance = null, bool isFilterFunction = false)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.stages = stages;
            this.performances = performances;
            this.isFilterFunction = isFilterFunction;

            labelAccountName.Text = userAccount.FullName;

            PopulateComponents();

            isValid = false;
            logOut = false;

            if (currentPerformance != null)
            {
                this.currentPerformance = currentPerformance;
                PopulateFields();
            }
            else this.currentPerformance = new Performance();
        }

        private void DateTimePickerPerfomanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPerformanceName.Focus();
        }
        private void TextBoxPerformanceName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxBaseTicketPrice.Focus();
        }
        private void TextBoxBaseTicketPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) comboBoxStage.Focus();
        }
        private void ComboBoxStage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSave.Focus();
        }

        private void TextBoxBaseTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SavePerformance();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void PopulateComponents()
        {
            dateTimePickerPerfomanceDate.MinDate = DateTime.Now.Date;
            dateTimePickerDuration.Value = (DateTime.Today) + (AppConstants.InitialPerformanceDuration);

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            PopulateComboBox();

            if (isFilterFunction) SetFilterParameters();
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
            else comboBoxStage.SelectedIndex = 0;
        }
        private void SetFilterParameters()
        {
            dateTimePickerPerfomanceDate.MinDate = defaultDate;
            dateTimePickerPerfomanceDate.Value = defaultDate;
            dateTimePickerDuration.MinDate = defaultDate;
            dateTimePickerDuration.Value = defaultDate;
            comboBoxStage.Items.Add("Undefined");
            comboBoxStage.SelectedIndex = comboBoxStage.Items.Count - 1;

            FormConfigurator.SetAutoCompleteForTextBox(textBoxPerformanceName, performances.Select(performance => performance.Name).Distinct().ToArray());
            FormConfigurator.SetAutoCompleteForTextBox(textBoxBaseTicketPrice, performances.Select(performance => performance.Price.ToString()).Distinct().ToArray());
        }
        private void PopulateFields()
        {
            dateTimePickerPerfomanceDate.Value = currentPerformance.LocalPerformanceDateTime;
            textBoxPerformanceName.Text = currentPerformance.Name;
            textBoxBaseTicketPrice.Text = Convert.ToString(currentPerformance.Price);
            dateTimePickerDuration.Value = DateTime.Today + currentPerformance.Duration;

            comboBoxStage.SelectedIndex = GetIndexOfStage();
        }
        private int GetIndexOfStage()
        {
            for (int i = 0; i < stages.Count; i++)
            {
                if (stages[i].Id == currentPerformance.StageId) return i;
            }
            return -1;
        }

        private void SavePerformance()
        {
            CreatePerformance();
            PerformanceValidator validator = new PerformanceValidator(performances);
            if (isFilterFunction || validator.Validate(currentPerformance, out string errorMessage))
            {
                isValid = true;
                this.Close();
            }
            else MessageBox.Show(
                                errorMessage,
                                "Performance error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }

        private void CreatePerformance()
        {
            currentPerformance.Name = textBoxPerformanceName.Text;
            currentPerformance.LocalPerformanceDateTime = dateTimePickerPerfomanceDate.Value == defaultDate ? DateTime.MinValue : dateTimePickerPerfomanceDate.Value;
            currentPerformance.Price = string.IsNullOrWhiteSpace(textBoxBaseTicketPrice.Text) ? double.NaN : Convert.ToDouble(textBoxBaseTicketPrice.Text);
            currentPerformance.Duration = dateTimePickerDuration.Value == defaultDate ? TimeSpan.Zero : new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);

            if (comboBoxStage.SelectedIndex < stages.Count && currentPerformance.StageId != stages[comboBoxStage.SelectedIndex].Id)
            {
                if (currentPerformance.StageId != Guid.Empty)
                {
                    DialogResult result =
                                        MessageBox.Show(
                                                    "If you change the stage, all tickets will be cancelled.\n" +
                                                    "Are you sure you want to do this?",
                                                    "Stage warning!",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                    if (result == DialogResult.No) return;
                }

                currentPerformance.AvailablePositions = stages[comboBoxStage.SelectedIndex].GetPositions();
                currentPerformance.RemoveAllTickets();
                currentPerformance.StageId = stages[comboBoxStage.SelectedIndex].Id;
            }
        }

        public Performance GetPerformance()
        {
            return currentPerformance;
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
