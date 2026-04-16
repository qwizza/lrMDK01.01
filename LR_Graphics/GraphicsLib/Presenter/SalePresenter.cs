using GraphicsLib.Model;
using GraphicsLib.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib.Presenter
{
    public class SalePresenter
    {
        private readonly SaleModel _model;
        private readonly List<ISaleView> _views;
        public SalePresenter(List<ISaleView> views)
        {
            _model = new SaleModel();
            _model.LoadData();
            _views = views;
        }
        public List<Item> GetAllItems() => _model.GetItems();

        public void SelectedItemChanged(string itemName)
        {
            var records = _model.GetRecordsForItem(itemName);
            foreach (var view in _views) view.DisplayChart(records);
        }
        public double GetContributionPercent(Item item)
        {
            double total = _model.GetTotalRevenue();
            return total == 0 ? 0 : Math.Round((_model.GetRevenueForItem(item) / total) * 100, 2);
        }
    }
}
