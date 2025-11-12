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
        }
    }
}
