using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class EditPerformanceForm : MetroFramework.Forms.MetroForm
    {

        private List<Stage> stages;

        private bool isValid;

        private int currentIndex;

        private Performance performance;
        private List<Performance> performances;

        public EditPerformanceForm(List<Stage> stages, List<Performance> performances, int currentIndex)
        {
            InitializeComponent();
            this.stages = stages;
            this.performance = performances[currentIndex];
            this.performances= performances;
            this.currentIndex = currentIndex;

            dateTimePickerPerfomanceDate.MinDate = DateTime.Now.Date;

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();

            PopulateFields();

            UpdateDataGridTickets();

            DisableEditAndRemoveZone();

            isValid = false;
        }

        private void dataGridViewTickets_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
        }

        private void dataGridViewTickets_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
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
                buttonSave.Focus();
            }
        }

        private void BuyTicketFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyOfTicket();

            UpdateDataGridTickets();
            DisableEditAndRemoveZone();
        }

        private void ChangeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewTickets.CurrentRow.Index;

            performance.ChangeTicketStatus(index);

            UpdateDataGridTickets();
            DisableEditAndRemoveZone();
        }

        private void removeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewTickets.CurrentRow.Index;

            performance.RemoveTicket(index);

            UpdateDataGridTickets();
            DisableEditAndRemoveZone();
        }

        private void textBoxBaseTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorDoubleDigit(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateOfPerformance())
            {
                isValid = true;

                SavePerformance();

                this.Close();
            }
        }

        private void PopulateFields()
        {
            dateTimePickerPerfomanceDate.Value = performance.PerformanceDateTime;
            textBoxPerformanceName.Text = performance.Name;
            textBoxBaseTicketPrice.Text = Convert.ToString(performance.Price);
            dateTimePickerDuration.Value = DateTime.Today + performance.Duration;

            textBoxBaseTicketPrice.Enabled = false;
            comboBoxStage.Enabled = false;

            PopulateComboBox();
        }


        private void UpdateDataGridTickets()
        {
            dataGridViewTickets.Rows.Clear();

            foreach (StandardTicket ticket in performance.Tickets)
            {
                AddTicketToDataGrid(ticket);
            }
        }

        private void AddTicketToDataGrid(StandardTicket ticket)
        {
            dataGridViewTickets.Rows.Add(
                ticket.Index, 
                ticket.Type, 
                ticket.Position, 
                ticket.CalculatedPrice.ToString()+AppConstants.CurrencySymbol.ToString(), 
                ticket.Reserved ? "Yes" : "No", 
                ticket.GetAdditionalServices());
        }

        private void DisableEditAndRemoveZone()
        {
            if (dataGridViewTickets.CurrentRow != null)
            {
                ChangeStatusToolStripMenuItem.Enabled = true;
                removeTicketToolStripMenuItem.Enabled = true;
            }
            else
            {
                ChangeStatusToolStripMenuItem.Enabled = false;
                removeTicketToolStripMenuItem.Enabled = false;
            }
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
                if (stages[i].Index == performance.StageIndex)
                {
                    return i;
                }
            }
            return -1;
        }


        private void SavePerformance()
        {
            performance.PerformanceDateTime = dateTimePickerPerfomanceDate.Value;
            performance.Name = textBoxPerformanceName.Text;
            performance.Price = Convert.ToDouble(textBoxBaseTicketPrice.Text);
            performance.Duration = new TimeSpan(dateTimePickerDuration.Value.Hour, dateTimePickerDuration.Value.Minute, 0);

            if (stages[comboBoxStage.SelectedIndex].Index != performance.StageIndex)
            {
                performance.StageIndex = stages[comboBoxStage.SelectedIndex].Index;
                performance.RemoveAllTickets();
            }
        }

        private bool ValidateOfPerformance()
        {
            if (!ValidateOfPerformanceName()) return false;
            if (!ValidateOfPerformancePrice()) return false;
            if (!ValidateOfPerformanceDate()) return false;
            if (!ValidateOfPerformancesIntersects()) return false;
            if (!ValidateOfStageEdit()) return false;

            return true;
        }

        private bool ValidateOfPerformanceName()
        {
            if (!ParametersValidator.NameValidator(textBoxPerformanceName.Text))
            {
                MessageBox.Show(
                                "There was an error in the name of the performance: the name should be more than two characters long",
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
                                "StandardTicket price error",
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

        private bool ValidateOfPerformancesIntersects()
        {
            string intersectsPerformanceName = FindIntersectionPerformance();
            if (intersectsPerformanceName != null)
            {
                MessageBox.Show(
                               $"The screening of the current performance is interspersed with the screening of the {intersectsPerformanceName} performance in {stages[comboBoxStage.SelectedIndex].Name}",
                               "Performance error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                dateTimePickerPerfomanceDate.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfStageEdit()
        {
            if (stages[comboBoxStage.SelectedIndex].Index != performance.StageIndex)
            {
                DialogResult result =
                    MessageBox.Show(
                                "If you change the stage, all tickets will be cancelled.\n" +
                                "Are you sure you want to do this?",
                                "Stage warning!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    comboBoxStage.SelectedIndex = FindInitialStageIndex();

                    return false;
                }
            }

            return true;
        }

        private int FindInitialStageIndex()
        {
            for (int i = 0; i < stages.Count; i++)
            {
                if (stages[i].Index == performance.StageIndex)
                {
                    return i;
                }
            }

            return -1;
        }

        private string FindIntersectionPerformance()
        {
            DateTime currentDate = dateTimePickerPerfomanceDate.Value;

            int index = 0;

            foreach (Performance performance in performances)
            {
                if (performance.StageIndex == stages[comboBoxStage.SelectedIndex].Index)
                {
                    if ((currentDate - performance.PerformanceDateTime).Days < 1 && index!=currentIndex)
                    {
                        if (IsIntersectionOfPerformances(currentDate, performance))
                        {
                            return performance.Name;
                        }
                    }
                }

                index++;
            }

            return null;
        }

        private bool IsIntersectionOfPerformances(DateTime currentDate, Performance performance)
        {
            double currentTimeDifference = 0;
            double minTimeDifference = 0;

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


        private void BuyOfTicket()
        {
            BuyTicketForm buyTicketForm = new BuyTicketForm(stages, performance);
            buyTicketForm.ShowDialog();

            if (buyTicketForm.GetIsValid())
            {
                performance.BuyTicket(buyTicketForm.GetNewTicket());
            }
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public Performance GetNewPerformance()
        {
            return performance;
        }
    }
}
