using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class AddEditPerformanceForm : MetroFramework.Forms.MetroForm
    {

        private readonly List<Stage> stages;
        private readonly List<Performance> performances;
        private readonly Performance currentPerformance;

        private bool isValid;
        private bool logOut;

        public AddEditPerformanceForm(Employee userAccount, List<Stage> stages, List<Performance> performances, Performance currentPerformance = null)
        {
            InitializeComponent();

            this.stages = stages;
            this.performances = performances;

            labelAccountName.Text = userAccount.FullName;

            PopulateComponents();

            isValid = false;
            logOut = false;

            if (currentPerformance != null)
            {
                this.currentPerformance = currentPerformance;
                PopulateFields();
            }
            else
                this.currentPerformance = new Performance(new PerformanceBaseService());
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
        private void PopulateFields()
        {
            dateTimePickerPerfomanceDate.Value = currentPerformance.PerformanceDateTime;
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
            if (validator.Validate(currentPerformance, out string errorMessage))
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
            currentPerformance.PerformanceDateTime = dateTimePickerPerfomanceDate.Value;
            currentPerformance.Price = Convert.ToDouble(textBoxBaseTicketPrice.Text);
            currentPerformance.Duration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);

            if (currentPerformance.StageId != stages[comboBoxStage.SelectedIndex].Id)
            {
                if (currentPerformance.StageId != null)
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
