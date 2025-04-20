using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.IO;

namespace CourseProject_ShowDesk.Scripts.Utilities.Helpers
{
    public class ReceiptService
    {
        private readonly Performance currentPerformance;
        private readonly Stage currentStage;
        private readonly Employee userAccount;

        public ReceiptService(Performance currentPerformance, Stage currentStage, Employee userAccount)
        {
            this.currentPerformance = currentPerformance;
            this.currentStage = currentStage;
            this.userAccount = userAccount;
        }

        public void CreateStandardReceipt(StandardTicket ticket, string filePath)
        {
            Document receipt = new Document();
            string divider = new string('-', 70);

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
        }

        private void AddReceiptHeader(Document doc)
        {
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph title = new Paragraph($"{AppConstants.CompanyName}\n", titleFont);
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
                $"Date: {currentPerformance.LocalPerformanceDateTime.ToShortDateString()}  " +
                $"Time: {currentPerformance.LocalPerformanceDateTime.TimeOfDay}"
                ));
            doc.Add(new Paragraph(
                $"Stage: {currentStage.Name}"
                ));
            doc.Add(new Paragraph(
                $"Zone: {currentStage.SeatList[ticket.Position - 1].CurrentZone.Name}"
                ));
            doc.Add(new Paragraph(
                $"Seat: {ticket.Position}"
                ));
            doc.Add(new Paragraph(
                $"Ticket type: {ticket.Type}"
                ));
            doc.Add(new Paragraph(
                $"Price: {ticket.CalculatedPrice} " + AppConstants.CurrencySymbol
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
        public void PrintReceipt(string filePath)
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
