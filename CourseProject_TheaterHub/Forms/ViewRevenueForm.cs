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
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject_TheaterHub
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
            DateTime minDate, maxDate;
            if (performances.Count == 0)
            {
                groupBoxPeriod.Enabled = false;
                groupBoxRevenue.Enabled = false;
            }
            else
            {
                minDate = maxDate = performances[0].PerformanceDate;
                foreach (Performance performance in performances)
                {
                    if (minDate > performance.PerformanceDate)
                    {
                        minDate = performance.PerformanceDate;
                    }
                    if (maxDate < performance.PerformanceDate)
                    {
                        maxDate = performance.PerformanceDate;
                    }
                }

                dateTimePickerStartDate.MinDate = minDate;
                dateTimePickerStartDate.MaxDate = maxDate;
                dateTimePickerFinishDate.MinDate = minDate;
                dateTimePickerFinishDate.MaxDate = maxDate;
                dateTimePickerStartDate.Value = minDate;
                dateTimePickerFinishDate.Value = maxDate;
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

        private static void Swap<T>(List<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();

            chartRevenue.Series.Clear();

            chartRevenue.Titles.Add("Revenue");

            Series series = chartRevenue.Series.Add("Revenue");

            for (int i = 0; i < performances.Count; i++)
            {
                for (int j = 0; j < performances.Count; j++)
                {
                    if (performances[i].PerformanceDate < performances[j].PerformanceDate)
                    {
                        Swap(performances, i, j);
                    }
                }
            }

            Dictionary<string, double> data = new Dictionary<string, double>();
            foreach (Performance spectacle in performances)
            {
                DateTime dtfrom = dateTimePickerStartDate.Value.Date;
                DateTime dtto = dateTimePickerFinishDate.Value;

                if ((spectacle.PerformanceDate < dtfrom) ||
                    (spectacle.PerformanceDate > dtto))
                {
                    continue;
                }
                string key = Convert.ToString(spectacle.PerformanceDate.Month) + "." + Convert.ToString(spectacle.PerformanceDate.Year);
                if (data.ContainsKey(key))
                {
                    data[key] = data[key] + spectacle.GetRevenue();
                }
                else
                {
                    data.Add(key, spectacle.GetRevenue());
                }
            }

            foreach (KeyValuePair<string, double> record in data)
            {
                series.Points.AddXY(Convert.ToString(record.Key), record.Value);
            }
        }
    }
}
