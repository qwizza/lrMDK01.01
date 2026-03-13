using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.Model
{
    public class SalesBookModel
    {
        private Dictionary<BookItem, List<Sale>> salesByItems_ =
            new Dictionary<BookItem, List<Sale>>();

        public void AddSales(BookItem item, List<Sale> sales)
        {
            if (salesByItems_.ContainsKey(item))
            {
                salesByItems_[item].AddRange(sales);
            }
            else
            {
                salesByItems_.Add(item, sales);
            }
        }

        public List<Sale> LoadSalesForItem(string genreName)
        {
            List<BookItem> allItems = salesByItems_.Keys.ToList();
            BookItem targetItem = allItems.Find(item => item.Genre == genreName);
            if (targetItem != null)
            {
                return salesByItems_[targetItem];
            }
            return new List<Sale>();
        }

        public bool Load()
        {
            AddSales(new BookItem { Genre = "Фантастика", Price = 450 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 2, 1), Count = 12 },
                    new Sale {Time = new DateTime(2026, 2, 2), Count = 8 },
                    new Sale {Time = new DateTime(2026, 2, 3), Count = 15 },
                    new Sale {Time = new DateTime(2026, 2, 4), Count = 20 },
                    new Sale {Time = new DateTime(2026, 2, 5), Count = 18 },
                    new Sale {Time = new DateTime(2026, 2, 6), Count = 25 },
                    new Sale {Time = new DateTime(2026, 2, 7), Count = 30 },
                });

            AddSales(new BookItem { Genre = "Детектив", Price = 380 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 2, 1), Count = 20 },
                    new Sale {Time = new DateTime(2026, 2, 2), Count = 18 },
                    new Sale {Time = new DateTime(2026, 2, 3), Count = 22 },
                    new Sale {Time = new DateTime(2026, 2, 4), Count = 25 },
                    new Sale {Time = new DateTime(2026, 2, 5), Count = 19 },
                    new Sale {Time = new DateTime(2026, 2, 6), Count = 28 },
                    new Sale {Time = new DateTime(2026, 2, 7), Count = 35 },
                });

            AddSales(new BookItem { Genre = "Учебная литература", Price = 550 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 2, 1), Count = 5 },
                    new Sale {Time = new DateTime(2026, 2, 2), Count = 7 },
                    new Sale {Time = new DateTime(2026, 2, 3), Count = 10 },
                    new Sale {Time = new DateTime(2026, 2, 4), Count = 12 },
                    new Sale {Time = new DateTime(2026, 2, 5), Count = 9 },
                    new Sale {Time = new DateTime(2026, 2, 6), Count = 15 },
                    new Sale {Time = new DateTime(2026, 2, 7), Count = 8 },
                });

            return true;
        }

        public List<string> GetAllGenres()
        {
            return salesByItems_.Keys.Select(item => item.Genre).ToList();
        }

        public double GetTotalRevenue()
        {
            double result = 0;
            foreach (var keyValue in salesByItems_)
            {
                BookItem item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }
            return result;
        }

        public double GetProfitByGenre(string genreName)
        {
            BookItem item = GetItem(genreName);
            if (item != null && salesByItems_.ContainsKey(item))
            {
                return salesByItems_[item].Sum(sale => sale.Count * item.Price);
            }
            return 0;
        }

        public BookItem GetItem(string genreName)
        {
            foreach (var keyValue in salesByItems_)
            {
                BookItem item = keyValue.Key;
                if (item.Genre == genreName)
                {
                    return item;
                }
            }
            return null;
        }

        public int[] GetSalesForLast7Days(string genreName)
        {
            int[] sales = new int[7];
            BookItem item = GetItem(genreName);

            if (item != null && salesByItems_.ContainsKey(item))
            {
                DateTime today = DateTime.Today;
                for (int i = 0; i < 7; i++)
                {
                    DateTime day = today.AddDays(-6 + i);
                    var sale = salesByItems_[item].FirstOrDefault(s => s.Time.Date == day.Date);
                    sales[i] = sale?.Count ?? 0;
                }
            }
            return sales;
        }
    }
}


