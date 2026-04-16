using GraphicsLib.Presenter;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Graphics.View
{
    public class SalePieChart : LiveCharts.WinForms.PieChart
    {
        public void UpdateData(SalePresenter presenter)
        {
            var series = new SeriesCollection();
            foreach (var item in presenter.GetAllItems())
            {
                series.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double> { presenter.GetContributionPercent(item) },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y}%"
                });
            }
            Series = series;
        }
    }
}
