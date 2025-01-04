using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject_ShowDesk
{
    public partial class ViewRevenueForm : MetroFramework.Forms.MetroForm
    {

        private List<Performance> performances;

        public ViewRevenueForm(List<Performance> performances)
        {
            InitializeComponent();

            this.performances = performances;

            SetDateLimit();
        }

        public void SetDateLimit()
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
        }

        private void CreateGraph()
        {
            ClearGraph();

            chartRevenue.Titles.Add("Revenue");

            Series series = chartRevenue.Series.Add("Revenue");

            performances = SortPerformancesByDate(performances);

            Dictionary<string, double> revenueDictionary = CreateRevenueDictionary(performances);

            BuildGraph(series, revenueDictionary);
        }

        private void ClearGraph()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();

            chartRevenue.Series.Clear();
        }

        private List<Performance> SortPerformancesByDate(List<Performance> performances)
        {
            for (int i = 0; i < performances.Count - 1; i++)
            {
                for (int j = 0; j < performances.Count - i - 1; j++)
                {
                    if (performances[i].PerformanceDateTime < performances[j].PerformanceDateTime)
                    {
                        Performance temp = performances[i];
                        performances[i] = performances[j];
                        performances[j] = temp;
                    }
                }
            }

            return performances;
        }

        private Dictionary<string, double> CreateRevenueDictionary(List<Performance> performances)
        {
            Dictionary<string, double> revenueDictionary = new Dictionary<string, double>();

            foreach (Performance performance in performances)
            {
                DateTime dateStart = dateTimePickerStartDate.Value.Date;
                DateTime dateFinish = dateTimePickerFinishDate.Value.Date;

                if (!(
                    (performance.PerformanceDateTime < dateStart) ||
                    (performance.PerformanceDateTime > dateFinish)
                    ))
                {
                    string key = Convert.ToString(performance.PerformanceDateTime.Month) + "." + Convert.ToString(performance.PerformanceDateTime.Year);

                    if (revenueDictionary.ContainsKey(key))
                    {
                        revenueDictionary[key] = revenueDictionary[key] + performance.GetRevenue();
                    }
                    else
                    {
                        revenueDictionary.Add(key, performance.GetRevenue());
                    }
                }
            }
            return revenueDictionary;
        }

        private void BuildGraph(Series series, Dictionary<string, double> revenueDictionary)
        {
            foreach (KeyValuePair<string, double> part in revenueDictionary)
            {
                series.Points.AddXY(Convert.ToString(part.Key), part.Value);
            }
        }
    }
}
