using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib.Model
{
    public class SaleModel
    {
        private Dictionary<Item, List<BooksSale>> _data = new Dictionary<Item, List<BooksSale>>();

        public void LoadData()
        {
            var fantasy = new Item { Name = "Фантастика", PriceSaleDay = 700 };
            var detective = new Item { Name = "Детектив", PriceSaleDay = 500 };
            var educational_lit = new Item { Name = "Учебная литература", PriceSaleDay = 400 };
            var comics = new Item { Name = "Комиксы", PriceSaleDay = 800 };

            _data.Add(fantasy, new List<BooksSale> {
            new BooksSale { Date = DateTime.Today.AddDays(-4), Quantity = 5 },
            new BooksSale { Date = DateTime.Today.AddDays(-3), Quantity = 2 },
            new BooksSale { Date = DateTime.Today.AddDays(-2), Quantity = 7 },
            new BooksSale { Date = DateTime.Today.AddDays(-1), Quantity = 3 },
            new BooksSale { Date = DateTime.Today, Quantity = 10 }
        });

            _data.Add(detective, new List<BooksSale> {
            new BooksSale { Date = DateTime.Today.AddDays(-4), Quantity = 6 },
            new BooksSale { Date = DateTime.Today.AddDays(-3), Quantity = 4 },
            new BooksSale { Date = DateTime.Today.AddDays(-2), Quantity = 8 },
            new BooksSale { Date = DateTime.Today.AddDays(-1), Quantity = 6 },
            new BooksSale { Date = DateTime.Today, Quantity = 7 }
        });

            _data.Add(educational_lit, new List<BooksSale> {
            new BooksSale { Date = DateTime.Today.AddDays(-4), Quantity = 5 },
            new BooksSale { Date = DateTime.Today.AddDays(-3), Quantity = 4 },
            new BooksSale { Date = DateTime.Today.AddDays(-2), Quantity = 2 },
            new BooksSale { Date = DateTime.Today.AddDays(-1), Quantity = 3 },
            new BooksSale { Date = DateTime.Today, Quantity = 1 }
        });

            _data.Add(comics, new List<BooksSale> {
            new BooksSale { Date = DateTime.Today.AddDays(-4), Quantity = 5 },
            new BooksSale { Date = DateTime.Today.AddDays(-3), Quantity = 7 },
            new BooksSale { Date = DateTime.Today.AddDays(-2), Quantity = 9 },
            new BooksSale { Date = DateTime.Today.AddDays(-1), Quantity = 8 },
            new BooksSale { Date = DateTime.Today, Quantity = 9 }
        });
        }

        public List<Item> GetItems() => _data.Keys.ToList();

        public List<BooksSale> GetRecordsForItem(string name) =>
            _data.FirstOrDefault(x => x.Key.Name == name).Value ?? new List<BooksSale>();

        public double GetRevenueForItem(Item item) =>
            _data[item].Sum(r => r.Quantity * item.PriceSaleDay);

        public double GetTotalRevenue() =>
            _data.Keys.Sum(item => GetRevenueForItem(item));
    }
}
