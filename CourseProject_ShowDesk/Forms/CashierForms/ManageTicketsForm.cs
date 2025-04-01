using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Utilities;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
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
using PdfiumViewer;
using System.Drawing.Printing;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using SharpCompress.Common;
using System.Net.Sockets;
using PdfiumPrinter;
using System.Diagnostics;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ManageTicketsForm : MetroFramework.Forms.MetroForm
    {
        private readonly Stage currentStage;
        private Performance currentPerformance;
        private readonly PerformanceBaseService dataBase;
        private readonly Employee userAccount;

        public ManageTicketsForm(Employee userAccount,Stage currentStage, Performance currentPerformance)
        {
            InitializeComponent();

            this.currentStage = currentStage;
            this.currentPerformance = currentPerformance;
            this.userAccount = userAccount;
            dataBase=new PerformanceBaseService();

            labelAccountName.Text = userAccount.FullName;

            timerUpdate.Interval = AppConstants.UpdateTicketsInterval;

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
            BuyTicketForm buyTicketForm = new BuyTicketForm(userAccount,currentStage, currentPerformance);
            
            this.Hide();
            buyTicketForm.ShowDialog();
            this.Show();

            if (buyTicketForm.GetIsValid())
            {
                foreach (StandardTicket ticket in buyTicketForm.GetNewTickets())
                {
                    currentPerformance.BuyTicket(ticket);
                    GenerateReceiptPdf(ticket);
                }
            }
        }

        private void GenerateReceiptPdf(StandardTicket ticket)
        {
            string filePath = AppConstants.SavePathReceipt.Trim();

            if (filePath.Length == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF файли (*.pdf)|*.pdf",
                    Title = "Save receipt",
                    FileName = $"Ticket_{ticket.Id.ToString()}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("File path is empty",
                        "Save receipt error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                filePath = saveFileDialog.FileName;
            }

            Document receipt = new Document();
            string divider = new string('-', 70);

            try
            {
                PdfWriter.GetInstance(receipt, new FileStream(filePath, FileMode.Create));
                receipt.Open();
                AddReceiptHeader(receipt);
                receipt.Add(new Paragraph(divider));
                AddReceiptBoughtInfo(receipt);
                receipt.Add(new Paragraph(divider));
                AddReceiptMain(receipt, ticket);
                receipt.Add(new Paragraph(divider));
                AddReceiptFooter(receipt);
                receipt.Close();

                if (AppConstants.IsPrintReceipt) PrintPdf(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Receipt error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddReceiptHeader(Document doc)
        {
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph title = new Paragraph("«ShowDesk»\n", titleFont);
            title.Alignment = Element.ALIGN_LEFT;
            doc.Add(title);
        }
        private void AddReceiptBoughtInfo(Document doc)
        {
            doc.Add(new Paragraph(
                $"Bought: {DateTime.Now}"
                ));
            doc.Add(new Paragraph(
                $"Cashier: {userAccount.FullName}"
                ));
        }
        private void AddReceiptMain(Document doc, StandardTicket ticket)
        {
            doc.Add(new Paragraph(
                $"Name: {currentPerformance.Name}"
                ));
            doc.Add(new Paragraph(
                $"Date: {currentPerformance.PerformanceDateTime.ToShortDateString()}  " +
                $"Time: {currentPerformance.PerformanceDateTime.TimeOfDay}"
                ));
            doc.Add(new Paragraph(
                $"Stage: {currentStage.Name}"
                ));
            doc.Add(new Paragraph(
                $"Zone: {currentStage.SeatList[ticket.Position-1].CurrentZone.Name}"
                ));
            doc.Add(new Paragraph(
                $"Seat: {ticket.Position}"
                ));
            doc.Add(new Paragraph(
                $"Ticket type: {ticket.Type}"
                ));
            doc.Add(new Paragraph(
                $"Price: {ticket.CalculatedPrice} "+AppConstants.CurrencySymbol
                ));
            doc.Add(new Paragraph(
                $"\nTicket id: {ticket.Id}", 
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
                ));
        }
        private void AddReceiptFooter(Document doc)
        {
            doc.Add(new Paragraph(
                "\nThank you for your purchase! " +
                "We wish you a pleasant viewing experience!", 
                FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10)
                ));
        }
        private void PrintPdf(string filePath)
        {
            //using (var document = PdfiumViewer.PdfDocument.Load(filePath))
            //{
            //    using (PrintDocument printDoc = document.CreatePrintDocument())
            //    {
            //        printDoc.Print(); 
            //    }
            //}
            //var printer = new PdfPrinter();

            //printer.Print(filePath);
            //using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //{
            //    PdfReader reader = new PdfReader(fs);
            //    PdfPrintPageEventHelper helper = new PdfPrintPageEventHelper();
            //    PdfWriter writer = PdfWriter.GetInstance(helper, fs);
            //    helper.OnEndPage(writer, reader);
            //    helper.Print();
            //}
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = filePath, // Шлях до файлу PDF
                Verb = "print", // Використовує команду "print"
                CreateNoWindow = true, // Без відкриття вікна
                WindowStyle = ProcessWindowStyle.Hidden // Сховане вікно
            };
            Process.Start(processStartInfo);

        }
    }
}
