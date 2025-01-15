using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject_ShowDesk
{
    public partial class ViewRevenueForm : MetroFramework.Forms.MetroForm
    {

        private List<Performance> performances;

        private int formMinWidth = 333;
        private int formMaxWidth = 955;

        public ViewRevenueForm(List<Performance> performances)
        {
            InitializeComponent();

            this.performances = performances;

            this.Width = formMinWidth;
            groupBoxForm.Width = formMinWidth;

            labelCurrency.Text = AppConstants.CurrencySymbol.ToString();
            labelCurrency2.Text = AppConstants.CurrencySymbol.ToString();

            PopulateComboBoxChartType();

            SetDateLimit();
        }

        private void dateTimePickerStartDate_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerFinishDate.Focus();
            }
        }

        private void dateTimePickerFinishDate_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCalculate.Focus();
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFinishDate.MinDate = dateTimePickerStartDate.Value;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStartDate.MaxDate = dateTimePickerFinishDate.Value;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CreateGraph();
            timerRevenue.Enabled = true;
        }

        private void timerRevenue_Tick(object sender, EventArgs e)
        {
            GrowUpOfForm();
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
            if (performances.Count == 0)
            {
                groupBoxPeriod.Enabled = false;
                groupBoxRevenue.Enabled = false;
            }
            else
            {
                DateTime minDate = GetMinDate(performances);
                DateTime maxDate = GetMaxDate(performances);

                dateTimePickerStartDate.MinDate = minDate;
                dateTimePickerStartDate.MaxDate = maxDate;
                dateTimePickerFinishDate.MinDate = minDate;
                dateTimePickerFinishDate.MaxDate = maxDate;
                dateTimePickerStartDate.Value = minDate;
                dateTimePickerFinishDate.Value = maxDate;
            }
        }

        private DateTime GetMinDate(List<Performance> performances)
        {
            DateTime minDate = performances[0].PerformanceDateTime;

            foreach (Performance performance in performances)
            {
                if (minDate > performance.PerformanceDateTime)
                {
                    minDate = performance.PerformanceDateTime;
                }
            }

            return minDate;
        }

        private DateTime GetMaxDate(List<Performance> performances)
        {
            DateTime maxDate = performances[0].PerformanceDateTime;

            foreach (Performance performance in performances)
            {
                if (maxDate < performance.PerformanceDateTime)
                {
                    maxDate = performance.PerformanceDateTime;
                }
            }

            return maxDate;
        }

        private void CreateGraph()
        {
            chartRevenue.Series.Clear();

            chartRevenue.Series.Add(CreateSeries());

            Calculate(FilterPerformanceByDate(performances));
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

        private List<Performance> FilterPerformanceByDate(List<Performance> performances)
        {
            List<Performance> filteredPerformances = new List<Performance>();

            DateTime dateStart = dateTimePickerStartDate.Value.Date;
            DateTime dateFinish = dateTimePickerFinishDate.Value.Date;

            foreach (Performance performance in performances)
            {
                if (performance.PerformanceDateTime > dateStart &&
                    performance.PerformanceDateTime < dateFinish)
                {
                    filteredPerformances.Add(performance);
                }
            }

            return performances;
        }

        private void Calculate(List<Performance> performances)
        {
            double dayRevenue= performances[0].GetRevenue();
            double sumRevenue = 0;
            int dayCount = 1;
            DateTime thisDate= performances[0].PerformanceDateTime.Date;
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
            series.Points[series.Points.Count - 1].ToolTip = $"Date: {thisDate.ToShortDateString()}\nRevenue: {dayRevenue.ToString("0.00")+AppConstants.CurrencySymbol}";
        }

        private void GrowUpOfForm()
        {
            if(this.Width<formMaxWidth)
            {
                this.Width +=5;
                groupBoxForm.Width += 5;
            }
            else
            {
                timerRevenue.Enabled = false;
            }
        }
    }
}
