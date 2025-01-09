using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class EditPerformanceForm : MetroFramework.Forms.MetroForm
    {

        private List<Stage> stages;

        private bool isValid;

        private Performance performance;

        public EditPerformanceForm(List<Stage> stages, Performance performance)
        {
            InitializeComponent();
            this.stages = stages;
            this.performance = performance;

            dateTimePickerPerfomanceDate.MinDate = DateTime.Now.Date;

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
        }

        private void ChangeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performance.ChangeTicketStatus(dataGridViewTickets.CurrentRow.Index);

            UpdateDataGridTickets();
            DisableEditAndRemoveZone();
        }

        private void removeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performance.RemoveTicket(dataGridViewTickets.CurrentRow.Index);

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

            textBoxBaseTicketPrice.Enabled = false;
            comboBoxStage.Enabled = false;

            PopulateComboBox();
        }


        private void UpdateDataGridTickets()
        {
            dataGridViewTickets.Rows.Clear();

            foreach (StandardTicket ticket in performance.Tickets)
            {
                dataGridViewTickets.Rows.Add(ticket.Index, ticket.Type, ticket.Position, ticket.CalculatedPrice, Convert.ToString(ticket.Reserved ? "Yes" : "No"), ticket.GetAdditionalServices());
            }
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

            if (stages[comboBoxStage.SelectedIndex].Index != performance.StageIndex)
            {
                performance.StageIndex = stages[comboBoxStage.SelectedIndex].Index;
                performance.RemoveAllTickets();
            }
        }

        private bool ValidateOfPerformance()
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

            if(stages[comboBoxStage.SelectedIndex].Index != performance.StageIndex)
            {
                DialogResult result= 
                    MessageBox.Show(
                                "If you change the stage, all tickets will be cancelled.\n" +
                                "Are you sure you want to do this?",
                                "Stage warning!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                if(result==DialogResult.No)
                {
                    for(int i=0; i<stages.Count; i++)
                    {
                        if (stages[i].Index == performance.StageIndex)
                        {
                            comboBoxStage.SelectedIndex = i;
                            break;
                        }
                    }
                    return false;
                }
            }

            return true;
        }

        private void BuyOfTicket()
        {
            BuyTicketForm buyTicketForm = new BuyTicketForm(stages, performance);
            buyTicketForm.ShowDialog();

            if (buyTicketForm.GetIsValid())
            {
                performance.BuyTicket(buyTicketForm.GetNewTicket());
            }

            UpdateDataGridTickets();
            DisableEditAndRemoveZone();
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
