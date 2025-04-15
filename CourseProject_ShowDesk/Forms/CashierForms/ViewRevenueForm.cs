using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ViewRevenueForm : MetroFramework.Forms.MetroForm
    {
        private readonly PerformanceManager performanceManager;
        private bool logOut;

        public ViewRevenueForm(Employee userAccount, PerformanceManager performanceManager)
        {
            InitializeComponent();

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

            if (oldestPerformance== null)
            {
                groupBoxPeriod.Enabled = false;
                groupBoxRevenue.Enabled = false;
            }
            else
            {
                DateTime minDate = oldestPerformance.PerformanceDateTime;
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
            DateTime thisDate = performances[0].PerformanceDateTime.Date;
            KeyValuePair<string, double> maxRevenuePerformance = new KeyValuePair<string, double>(performances[0].Name, performances[0].GetRevenue());
            KeyValuePair<string, double> minRevenuePerformance = new KeyValuePair<string, double>(performances[0].Name, performances[0].GetRevenue());

            for (int i = 1; i < performances.Count; i++)
            {
                Performance performance = performances[i];

                if (performance.GetRevenue() > maxRevenuePerformance.Value)
                {
                    maxRevenuePerformance = new KeyValuePair<string, double>(performance.Name, performance.GetRevenue());
                }

                if (performance.GetRevenue() < minRevenuePerformance.Value)
                {
                    minRevenuePerformance = new KeyValuePair<string, double>(performance.Name, performance.GetRevenue());
                }

                if (thisDate == performance.PerformanceDateTime.Date)
                {
                    dayRevenue += performance.GetRevenue();
                }
                else
                {
                    AddPoint(thisDate, dayRevenue);

                    dayCount++;
                    dayRevenue = performance.GetRevenue();
                    thisDate = performance.PerformanceDateTime.Date;
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
