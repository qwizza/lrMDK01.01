using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<Sale> sales = GenerateSalesData(30);

            Console.WriteLine("Пример данных о продажах:");
            foreach (var sale in sales.Take(5))
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy} - {sale.Model}: {sale.Quantity} шт. по ${sale.Price}");
            }

            DateTime startDate = new DateTime(2025, 10, 1);
            DateTime endDate = new DateTime(2025, 10, 30);

            AnalyzeSales(sales, startDate, endDate);

            Console.WriteLine("Анализ за первую неделю:");
            AnalyzeSales(sales, new DateTime(2025, 10, 1), new DateTime(2025, 10, 7));
        }
        static List<Sale> GenerateSalesData(int days)
        {
            var phones = new[]
            {
                new { Model = "iPhone 15", Price = 999m, Cost = 700m },
                new { Model = "Samsung Galaxy S24", Price = 899m, Cost = 650m },
                new { Model = "Xiaomi Redmi Note 13", Price = 299m, Cost = 200m }
            };

            var sales = new List<Sale>();
            var random = new Random();
            var startDate = new DateTime(2024, 1, 1);

            for (int day = 0; day < days; day++)
            {
                var currentDate = startDate.AddDays(day);

                foreach (var phone in phones)
                {
                    int quantity = random.Next(0, 6);
                    if (quantity > 0)
                    {
                        sales.Add(new Sale
                        {
                            Date = currentDate,
                            Model = phone.Model,
                            Price = phone.Price,
                            Cost = phone.Cost,
                            Quantity = quantity
                        });
                    }
                }
            }
            return sales;
        }
        static void AnalyzeSales(List<Sale> sales, DateTime startDate, DateTime endDate)
        {
            var filteredSales = sales.Where(s => s.Date >= startDate && s.Date <= endDate).ToList();

            if (!filteredSales.Any())
            {
                Console.WriteLine("Нет данных за указанный период");
                return;
            }

            decimal totalRevenue = filteredSales.Sum(s => s.Price * s.Quantity);

            var phoneStats = filteredSales
                .GroupBy(s => s.Model)
                .Select(g => new { Model = g.Key, TotalQuantity = g.Sum(s => s.Quantity) })
                .ToList();

            var bestSelling = phoneStats.OrderByDescending(p => p.TotalQuantity).First();
            var worstSelling = phoneStats.OrderBy(p => p.TotalQuantity).First();

            var profitStats = filteredSales
                .GroupBy(s => s.Model)
                .Select(g => new
                {
                    Model = g.Key,
                    TotalProfit = g.Sum(s => (s.Price - s.Cost) * s.Quantity)
                })
                .OrderByDescending(p => p.TotalProfit)
                .Take(2)
                .ToList();

        }
    }
}
