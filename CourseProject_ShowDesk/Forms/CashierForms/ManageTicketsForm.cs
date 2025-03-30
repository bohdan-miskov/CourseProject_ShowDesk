using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Utilities;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ManageTicketsForm : MetroFramework.Forms.MetroForm
    {
        private readonly Stage currentStage;
        private Performance currentPerformance;
        private readonly PerformanceBaseService dataBase;

        public ManageTicketsForm(Stage currentStage, Performance currentPerformance)
        {
            InitializeComponent();

            this.currentStage = currentStage;
            this.currentPerformance = currentPerformance;

            dataBase=new PerformanceBaseService();

            UpdateDataGridTickets();
            DisableEditAndRemoveTicket();

            timerUpdate.Start();
        }
        private void DataGridViewTickets_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveTicket();
        }

        private void DataGridViewTickets_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveTicket();
        }
        private void ChangeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTicketStatus();

            UpdateDataFromDataBase();
        }

        private void RemoveTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTicket();

            UpdateDataFromDataBase();
        }
        private void BuyTicketFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyOfTicket();

            UpdateDataFromDataBase();
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataFromDataBase();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateDataFromDataBase();
        }
        private void ManageTicketsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerUpdate.Stop();
        }
        private void UpdateDataFromDataBase()
        {
            currentPerformance=dataBase.GetUpdatedPerformance(currentPerformance);

            UpdateDataGridTickets();
            DisableEditAndRemoveTicket();
        }
        private void UpdateDataGridTickets()
        {
            dataGridViewTickets.Rows.Clear();

            foreach (StandardTicket ticket in currentPerformance.Tickets)
            {
                AddTicketToDataGrid(ticket);
            }
        }

        private void AddTicketToDataGrid(StandardTicket ticket)
        {
            dataGridViewTickets.Rows.Add(
                ticket.Id,
                ticket.Index,
                ticket.Type,
                ticket.Position,
                ticket.CalculatedPrice.ToString() + AppConstants.CurrencySymbol.ToString(),
                ticket.Reserved ? "Yes" : "No",
                ticket.GetAdditionalServices());
        }

        private void DisableEditAndRemoveTicket()
        {
            if (dataGridViewTickets.CurrentRow != null)
            {
                changeStatusToolStripMenuItem.Enabled = true;
                removeTicketToolStripMenuItem.Enabled = true;
                changeStatusToolStripMenuItem1.Enabled = true;
                removeTicketToolStripMenuItem1.Enabled = true;
            }
            else
            {
                changeStatusToolStripMenuItem.Enabled = false;
                removeTicketToolStripMenuItem.Enabled = false;
                changeStatusToolStripMenuItem1.Enabled = false;
                removeTicketToolStripMenuItem1.Enabled = false;
            }
        }

        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewTickets.CurrentRow.Cells[0].Value.ToString()); 
        }

        private void ChangeTicketStatus()
        {
            Guid id = GetCurrentRowId();
            currentPerformance.ChangeTicketStatus(id);
        }

        private void RemoveTicket()
        {
            Guid id = GetCurrentRowId();
            currentPerformance.RemoveTicket(id);
        }

        private void BuyOfTicket()
        {
            currentPerformance = dataBase.GetUpdatedPerformance(currentPerformance);
            BuyTicketForm buyTicketForm = new BuyTicketForm(currentStage, currentPerformance);
            
            this.Hide();
            buyTicketForm.ShowDialog();
            this.Show();

            if (buyTicketForm.GetIsValid())
            {
                foreach (StandardTicket ticket in buyTicketForm.GetNewTickets())
                {
                    currentPerformance.BuyTicket(ticket);
                }
            }
        }
    }
}
