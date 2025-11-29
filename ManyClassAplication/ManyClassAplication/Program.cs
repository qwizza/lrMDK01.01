using System;
using System.Dynamic;
using System.Linq;


namespace ManyClassAplication
{
    class Program
    {

        static void Main(string[] args)
        {
            Goods car1 = new Goods();
            car1.SetName("Mercedes-Benz");
            car1.SetPrice(1200000);
            Goods car2 = new Goods();
            car2.SetName("УАЗ");
            car2.SetPrice(10000000);

            Warehouse storage = new Warehouse();
            storage.SetIdentifier(1);
            storage.SetLocation("Торжок, Студенческая 3.");
            storage.SetProductCount(car1, 2);
            storage.SetProductCount(car2, 5);

           
            Console.WriteLine("Адрес склада: " + storage.GetLocation());
            Console.WriteLine("Идентификатор склада: " + storage.GetIdentifier());

            Console.Write("Сумма всех товаров на складе: "); storage.CalculateMany();

            Report report = new Report();

            ReportRow row1 = new ReportRow();
            row1.Products = "Молоко";
            row1.Price = 89;
            row1.Quantity = 5;
            
            ReportRow row2 = new ReportRow();
            row2.Products = "Йогурт";
            row2.Price = 129;
            row2.Quantity = 6;
            
            ReportRow row3 = new ReportRow();
            row3.Products = "Кефир";
            row3.Price = 89;
            row3.Quantity = 4;

            report.AddReport(row1);
            report.AddReport(row2);
            report.AddReport(row3);

            report.PrintReport();


        }
    }
}
