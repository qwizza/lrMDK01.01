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
            
        }
    }
}
