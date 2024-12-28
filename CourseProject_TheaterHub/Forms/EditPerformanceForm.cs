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

            ShowZone();

            UpdateDataGridTickets();

            DisableEditAndRemoveZone();

            isValid = false;
        }


        private void ShowZone()
        {
            dateTimePickerPerfomanceDate.Value = performance.PerformanceDate;
            textBoxName.Text = performance.Name;
            textBoxBaseTicketPrice.Text = Convert.ToString(performance.Price);

            textBoxBaseTicketPrice.Enabled = false;
            comboBoxStage.Enabled = false;

            PopulateComboBox();
        }


        private void UpdateDataGridTickets()
        {
            dataGridViewTickets.Rows.Clear();

            foreach (Ticket ticket in performance.Tickets)
            {
                string ticketType = "Undefined";
                if (ticket.GetType() == new Ticket().GetType())
                {
                    ticketType = "Base";
                }

                dataGridViewTickets.Rows.Add(ticket.Index, ticketType, ticket.Position, ticket.CalculatedPrice, Convert.ToString(ticket.Reserved ? "Yes" : "No"));
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
                buttonSave.Focus();
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
                for (int i = 0; i < stages.Count; i++)
                {
                    if (stages[i].Index == performance.StageIndex)
                    {
                        comboBoxStage.SelectedIndex = i;
                        break;
                    }
                }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!NameValidator(textBoxName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the performance: the name should be more than two characters long",
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

            if (stages[comboBoxStage.SelectedIndex].Index == performance.StageIndex)
            {
                performance.PerformanceDate = dateTimePickerPerfomanceDate.Value;
                performance.Name = textBoxName.Text;
                performance.Price = Convert.ToDouble(textBoxBaseTicketPrice.Text);
                performance.StageIndex = stages[comboBoxStage.SelectedIndex].Index;
            }
            else
            {
                performance.PerformanceDate = dateTimePickerPerfomanceDate.Value;
                performance.Name = textBoxName.Text;
                performance.Price = Convert.ToDouble(textBoxBaseTicketPrice.Text);
                performance.StageIndex = stages[comboBoxStage.SelectedIndex].Index;
                performance.RemoveAllTickets();
            }

            this.Close();
        }

        private void BuyTicketFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BuyTicketForm buyTicketForm = new BuyTicketForm(stages, performance);
            buyTicketForm.ShowDialog(this);

            if (buyTicketForm.GetIsValid())
            {
                performance.BuyTicket(buyTicketForm.GetNewTicket());
            }

            UpdateDataGridTickets();
            DisableEditAndRemoveZone();
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
