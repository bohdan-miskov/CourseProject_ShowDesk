using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ViewRevenueForm : MetroFramework.Forms.MetroForm
    {
        private readonly PerformanceManager performanceManager;
        private bool logOut;

        public ViewRevenueForm(Employee userAccount, PerformanceManager performanceManager)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.performanceManager = performanceManager;

            labelAccountName.Text = userAccount.FullName;
            logOut = false;

            PopulateComponents();
        }

        private void DateTimePickerStartDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerFinishDate.Focus();
        }

        private void DateTimePickerFinishDate_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonCalculate.Focus();
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFinishDate.MinDate = dateTimePickerStartDate.Value;
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStartDate.MaxDate = dateTimePickerFinishDate.Value;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            CreateGraph();
        }

        private void ButtonSavePdf_Click(object sender, EventArgs e)
        {
            GenerateStatisticsPdf();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void PopulateComponents()
        {
            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();
            labelCurrency2.Text = AppConstants.CurrencySymbol.ToString();

            PopulateComboBoxChartType();

            SetDateLimit();
        }

        private void PopulateComboBoxChartType()
        {
            comboBoxChartType.Items.Add("Line");
            comboBoxChartType.Items.Add("Column");
            comboBoxChartType.Items.Add("Spline");
            comboBoxChartType.Items.Add("Pie chart");

            comboBoxChartType.SelectedIndex = 0;
        }


        private void SetDateLimit()
        {
            Performance oldestPerformance = performanceManager.GetOldestPerformance();

            if (oldestPerformance == null)
            {
                groupBoxPeriod.Enabled = false;
                groupBoxRevenue.Enabled = false;
            }
            else
            {
                DateTime minDate = oldestPerformance.LocalPerformanceDateTime;
                DateTime maxDate = DateTime.Now;

                dateTimePickerStartDate.MinDate = minDate;
                dateTimePickerStartDate.MaxDate = maxDate;
                dateTimePickerFinishDate.MinDate = minDate;
                dateTimePickerFinishDate.MaxDate = maxDate;
                dateTimePickerStartDate.Value = minDate;
                dateTimePickerFinishDate.Value = maxDate;
            }
        }

        private void CreateGraph()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add(CreateSeries());

            Calculate(LoadPerformanceByDate());
            performanceManager.ResetPastPerformancesList();
        }

        private Series CreateSeries()
        {
            Series series = new Series("Revenue");

            if (comboBoxChartType.SelectedIndex == 0) series.ChartType = SeriesChartType.Line; ;
            if (comboBoxChartType.SelectedIndex == 1) series.ChartType = SeriesChartType.Column;
            if (comboBoxChartType.SelectedIndex == 2) series.ChartType = SeriesChartType.Spline;
            if (comboBoxChartType.SelectedIndex == 3) series.ChartType = SeriesChartType.Pie;

            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = System.Drawing.Color.Red;
            series.IsValueShownAsLabel = true;

            return series;
        }

        private List<Performance> LoadPerformanceByDate()
        {
            DateTime dateStart = dateTimePickerStartDate.Value.Date;
            DateTime dateFinish = dateTimePickerFinishDate.Value.Date;
            performanceManager.LoadPastPerformancesFromDatabase(dateStart, dateFinish);
            return performanceManager.PastPerformances;
        }

        private void Calculate(List<Performance> performances)
        {
            if (performances == null || performances.Count == 0)
            {
                MessageBox.Show(
                    "No performances have taken place yet",
                    "No performances",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            double dayRevenue = performances[0].GetRevenue();
            double sumRevenue = 0;
            int dayCount = 1;
            DateTime thisDate = performances[0].LocalPerformanceDateTime.Date;
            KeyValuePair<string, double> maxRevenuePerformance = new KeyValuePair<string, double>(performances[0].Name, performances[0].GetRevenue());
            KeyValuePair<string, double> minRevenuePerformance = new KeyValuePair<string, double>(performances[0].Name, performances[0].GetRevenue());

            for (int i = 1; i < performances.Count; i++)
            {
                Performance performance = performances[i];

                if (performance.GetRevenue() > maxRevenuePerformance.Value)
                    maxRevenuePerformance = new KeyValuePair<string, double>(performance.Name, performance.GetRevenue());

                if (performance.GetRevenue() < minRevenuePerformance.Value)
                    minRevenuePerformance = new KeyValuePair<string, double>(performance.Name, performance.GetRevenue());

                if (thisDate == performance.LocalPerformanceDateTime.Date)
                    dayRevenue += performance.GetRevenue();
                else
                {
                    AddPoint(thisDate, dayRevenue);

                    dayCount++;
                    dayRevenue = performance.GetRevenue();
                    thisDate = performance.LocalPerformanceDateTime.Date;
                }
                sumRevenue += performance.GetRevenue();
            }

            AddPoint(thisDate, dayRevenue);

            textBoxSum.Text = sumRevenue.ToString();
            textBoxAverage.Text = (sumRevenue / dayCount).ToString("0.00");
            textBoxBestPerformance.Text = maxRevenuePerformance.Key;
            textBoxWorstPerformance.Text = minRevenuePerformance.Key;
        }

        private void AddPoint(DateTime thisDate, double dayRevenue)
        {
            Series series = chartRevenue.Series[0];

            series.Points.AddXY(thisDate.ToShortDateString(), dayRevenue);
            series.Points[series.Points.Count - 1].ToolTip = $"Date: {thisDate.ToShortDateString()}\nRevenue: {dayRevenue.ToString("0.00") + AppConstants.CurrencySymbol}";
        }

        private void GenerateStatisticsPdf()
        {
            string startD = dateTimePickerStartDate.Value.ToShortDateString();
            string endD = dateTimePickerFinishDate.Value.ToShortDateString();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF файли (*.pdf)|*.pdf",
                Title = "Save receipt",
                FileName = $"Statistics_{startD}-{endD}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    CreateStatisticsPdf(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CreateStatisticsPdf(string filePath)
        {
            string tempImagePath = Path.GetTempFileName();
            chartRevenue.SaveImage(tempImagePath, ChartImageFormat.Png);
            string divider = new string('-', 70);

            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            AddTitle(doc);
            doc.Add(new Paragraph(divider));
            AddStatisticsHead(doc);
            doc.Add(new Paragraph(divider));
            AddStatisticsChart(doc, tempImagePath);
            doc.Add(new Paragraph(divider));
            AddStatisticsSummary(doc);

            doc.Close();

            File.Delete(tempImagePath);
        }
        private void AddTitle(Document doc)
        {
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph title = new Paragraph($"{AppConstants.CompanyName} Revenue Statistics\n", titleFont);
            title.Alignment = Element.ALIGN_LEFT;
            doc.Add(title);
        }
        private void AddStatisticsHead(Document doc)
        {
            doc.Add(new Paragraph($"Period: {dateTimePickerStartDate.Value.ToShortDateString()} – {dateTimePickerFinishDate.Value.ToShortDateString()}"));
            doc.Add(new Paragraph("\n"));
        }
        private void AddStatisticsChart(Document doc, string tempImagePath)
        {
            iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(tempImagePath);
            chartImage.ScaleToFit(500f, 300f);
            chartImage.Alignment = Element.ALIGN_CENTER;
            doc.Add(chartImage);
            doc.Add(new Paragraph("\n"));
        }
        private void AddStatisticsSummary(Document doc)
        {
            var textFont = FontFactory.GetFont("Arial", 12);
            doc.Add(new Paragraph($"Total Revenue: {textBoxSum.Text}{AppConstants.CurrencySymbol}", textFont));
            doc.Add(new Paragraph($"Average Revenue: {textBoxAverage.Text}{AppConstants.CurrencySymbol}", textFont));
            doc.Add(new Paragraph($"Best Performance: {textBoxBestPerformance.Text}", textFont));
            doc.Add(new Paragraph($"Worst Performance: {textBoxWorstPerformance.Text}", textFont));
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
