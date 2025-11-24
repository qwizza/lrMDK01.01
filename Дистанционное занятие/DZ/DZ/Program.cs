using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> sales = new List<Phone>();

            DateTime baseDate = new DateTime(2025, 10, 1);

            // iPhone с ценами и себестоимостью (double)
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", date = baseDate.AddDays(0), countSell = 1, price = 159999.0, cost = 96590.0 });
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", date = baseDate.AddDays(7), countSell = 0, price = 159999.0, cost = 96590.0 });
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", date = baseDate.AddDays(14), countSell = 0, price = 159999.0, cost = 96590.0 });
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", date = baseDate.AddDays(21), countSell = 2, price = 159999.0, cost = 96590.0 });

            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", date = baseDate.AddDays(0), countSell = 1, price = 135990.0, cost = 77990.0 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", date = baseDate.AddDays(7), countSell = 3, price = 135990.0, cost = 77990.0 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", date = baseDate.AddDays(14), countSell = 2, price = 135990.0, cost = 77990.0 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", date = baseDate.AddDays(21), countSell = 4, price = 135990.0, cost = 77990.0 });

            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", date = baseDate.AddDays(0), countSell = 2, price = 120999.0, cost = 70000.0 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", date = baseDate.AddDays(7), countSell = 5, price = 120999.0, cost = 70000.0 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", date = baseDate.AddDays(14), countSell = 0, price = 120999.0, cost = 70000.0 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", date = baseDate.AddDays(21), countSell = 1, price = 120999.0, cost = 70000.0 });

            // Samsung с ценами и себестоимостью (double)
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", date = baseDate.AddDays(0), countSell = 1, price = 126999.0, cost = 75000.0 });
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", date = baseDate.AddDays(7), countSell = 0, price = 126999.0, cost = 75000.0 });
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", date = baseDate.AddDays(14), countSell = 3, price = 126999.0, cost = 75000.0 });
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", date = baseDate.AddDays(21), countSell = 4, price = 126999.0, cost = 75000.0 });

            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", date = baseDate.AddDays(0), countSell = 0, price = 123999.0, cost = 72990.0 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", date = baseDate.AddDays(7), countSell = 0, price = 123999.0, cost = 72990.0 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", date = baseDate.AddDays(14), countSell = 2, price = 123999.0, cost = 72990.0 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", date = baseDate.AddDays(21), countSell = 3, price = 123999.0, cost = 72990.0 });

            // Huawei с ценами и себестоимостью (double)
            sales.Add(new Phone { brand = "Xiaomi", model = "14 Ultra", date = baseDate.AddDays(0), countSell = 4, price = 113999.0, cost = 70999.0 });
            sales.Add(new Phone { brand = "Xiaomi", model = "14 Ultra", date = baseDate.AddDays(7), countSell = 3, price = 113999.0, cost = 70999.0 });
            sales.Add(new Phone { brand = "Xiaomi", model = "14 Ultra", date = baseDate.AddDays(14), countSell = 5, price = 113999.0, cost = 70999.0 });
            sales.Add(new Phone { brand = "Xiaomi", model = "14 Ultra", date = baseDate.AddDays(21), countSell = 2, price = 113999.0, cost = 70999.0 });

            // Период для анализа
            DateTime startPeriod = baseDate;
            DateTime endPeriod = baseDate.AddDays(30);

            Console.WriteLine("=== Анализ продаж мобильных телефонов ===");
            Console.WriteLine($"Период анализа: {startPeriod:dd.MM.yyyy} - {endPeriod:dd.MM.yyyy}");
            Console.WriteLine();

            // а) Общая сумма проданного за период
            double totalRevenue = Function.GetTotalSalesInPeriod(sales, startPeriod, endPeriod);
            Console.WriteLine($"а) Общая сумма проданного за период: {totalRevenue:F2} руб.");
            Console.WriteLine();

            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            Console.WriteLine("б) Анализ продаж по моделям:");
            Function.FindBestSellingPhone(sales, startPeriod, endPeriod);
            Console.WriteLine();

            // в) Два самых прибыльных телефона
            Console.WriteLine("в) Анализ прибыльности:");
            Function.FindTopTwoProfitablePhones(sales, startPeriod, endPeriod);
            Console.WriteLine();

            
        }
    }
}
