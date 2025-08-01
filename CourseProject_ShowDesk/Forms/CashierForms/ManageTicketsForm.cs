﻿using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Helpers;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ManageTicketsForm : MetroFramework.Forms.MetroForm
    {
        private readonly Stage currentStage;
        private Performance currentPerformance;
        private readonly PerformanceBaseService dataBase;
        private readonly Employee userAccount;

        private readonly SearchDataGrid searchData;

        private bool logOut;

        public ManageTicketsForm(Employee userAccount, Stage currentStage, Performance currentPerformance)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this, true);

            this.currentStage = currentStage;
            this.currentPerformance = currentPerformance;
            this.userAccount = userAccount;
            dataBase = new PerformanceBaseService();

            labelAccountName.Text = userAccount.FullName;

            timerUpdate.Interval = AppConstants.UpdateTicketsInterval;

            logOut = false;

            timerUpdate.Start();

            searchData = new SearchDataGrid(dataGridViewTickets);
        }
        private void ManageTicketsForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridTickets();
            DisableEditAndRemoveTicket();
        }
        private void DataGridViewTickets_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveTicket();
        }

        private void DataGridViewTickets_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveTicket();
        }
        private async void ChangeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ChangeTicketStatusAsync();

            await UpdateDataFromDataBaseAsync();
        }

        private async void RemoveTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RemoveTicketAsync();

            await UpdateDataFromDataBaseAsync();
        }
        private async void BuyTicketFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await BuyOfTicketAsync();

            await UpdateDataFromDataBaseAsync();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchByFragment();
        }
        private void TextBoxSearchField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchByFragment();
        }
        private void DataGridViewTickets_KeyDown(object sender, KeyEventArgs e)
        {
            searchData.SearchNavigation(e);
        }
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            await UpdateDataFromDataBaseAsync();
        }

        private async void TimerUpdate_Tick(object sender, EventArgs e)
        {
            await UpdateDataFromDataBaseAsync();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void ManageTicketsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerUpdate.Stop();
        }
        private async Task UpdateDataFromDataBaseAsync()
        {
            FormConfigurator.SetActivePictureBoxUpdate(pictureBoxUpdate);
            currentPerformance = await dataBase.GetUpdatedPerformanceAsync(currentPerformance);

            UpdateDataGridTickets();
            DisableEditAndRemoveTicket();
            FormConfigurator.RemoveActivePictureBoxUpdate(pictureBoxUpdate);
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

        private async Task ChangeTicketStatusAsync()
        {
            Guid id = GetCurrentRowId();
            await currentPerformance.ChangeTicketStatusAsync(id);
            GenerateReceiptPdf(currentPerformance.GetTicketById(id));
        }

        private async Task RemoveTicketAsync()
        {
            Guid id = GetCurrentRowId();
            await currentPerformance.RemoveTicketAsync(id);
        }

        private async Task BuyOfTicketAsync()
        {
            currentPerformance =await dataBase.GetUpdatedPerformanceAsync(currentPerformance);
            BuyTicketForm buyTicketForm = new BuyTicketForm(userAccount, currentStage, currentPerformance);

            this.Hide();
            buyTicketForm.ShowDialog();

            if (buyTicketForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (buyTicketForm.GetIsValid())
            {
                foreach (StandardTicket ticket in buyTicketForm.GetNewTickets())
                {
                    try
                    {
                        await currentPerformance.BuyTicketAsync(ticket);
                    }
                    catch(InvalidOperationException)
                    {
                        MessageBox.Show(
                            $"This ticket {ticket.Id} is not accessible",
                            "Ticket error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        return;
                    }
                    if(!ticket.Reserved) GenerateReceiptPdf(ticket);
                }
            }
        }

        private void GenerateReceiptPdf(StandardTicket ticket)
        {
            string filePath = ChooseReceiptFilePath(ticket.Id);
            if (string.IsNullOrEmpty(filePath)) return;

            ReceiptService receiptService = new ReceiptService(currentPerformance, currentStage, userAccount);

            try
            {
                receiptService.CreateStandardReceipt(ticket, filePath);

                if (AppConstants.IsPrintReceipt) receiptService.PrintReceipt(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Receipt error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ChooseReceiptFilePath(Guid ticketId)
        {
            string filePath = AppConstants.SavePathReceipt.Trim();

            if (filePath.Length == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF файли (*.pdf)|*.pdf",
                    Title = "Save receipt",
                    FileName = $"Ticket_{ticketId}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("File path is empty",
                        "Save receipt error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return "";
                }
                filePath = saveFileDialog.FileName;
            }
            else filePath = Path.Combine(filePath, $"Ticket_{ticketId}.pdf");

            return filePath;
        }
        private void SearchByFragment()
        {
            string searchField = textBoxSearchField.Text.Trim();

            searchData.Search(searchField);

            if (searchData.HasResults()) searchData.HighlightCurrentResult();
            else MessageBox.Show(
                                "No results found",
                                "Not found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
    }
}
