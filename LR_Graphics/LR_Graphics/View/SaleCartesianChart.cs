using GraphicsLib;
using GraphicsLib.View;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LR_Graphics.View
{
    public class SaleCartesianChart : LiveCharts.WinForms.CartesianChart, ISaleView
    {
        public void DisplayChart(List<BooksSale> records)
        {
            if (records == null || records.Count == 0) return;

            var values = new ChartValues<int>();
            var labels = new List<string>();

            foreach (var rec in records)
            {
                values.Add(rec.Quantity);
                labels.Add(rec.Date.ToShortDateString());
            }
            AxisX.Clear();
            AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Дата",
                Labels = labels
            });
            Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Покупок",
                    Values = values
                }
            };
        }
    }
}
