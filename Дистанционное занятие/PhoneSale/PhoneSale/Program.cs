using PhoneShop;
using System;
using System.Collections.Generic;

namespace PhoneSale
{
    internal class Program
    {
        static void Main()
        {
            List<PhoneSales> sales = InputModule.CreateSalesData();

            DateTime startDate = new DateTime(2025, 11, 10);
            DateTime endDate = new DateTime(2025, 11, 13);

            List<PhoneSales> periodSales = AnalysisDataModule.GetSalesByPeriod(sales, startDate, endDate);
         if (periodSales.Count == 0)
            {
                Console.WriteLine("Нет продаж за указанный период");
                return;
            }

            var bestSeller = AnalysisDataModule.FindBestSeller(periodSales);
            var worstSeller = AnalysisDataModule.FindWorstSeller(periodSales);
            var topProfitPhones = AnalysisDataModule.FindTopProfitPhones(periodSales, 2);
            double totalRevenue = AnalysisDataModule.CalculateTotalRevenue(periodSales);

            PrintReport(periodSales, totalRevenue, bestSeller, worstSeller, topProfitPhones, startDate, endDate);
        }
        static void PrintReport(List<PhoneSales> sales, double totalRevenue,
                             (string, int) bestSeller, (string, int) worstSeller,
                             List<(string, double)> topProfitPhones,
                             DateTime startDate, DateTime endDate)
        {
            Console.WriteLine($"Отчет о продаже телефонов");
            Console.WriteLine($"Период: {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}");
            Console.WriteLine();

            Console.WriteLine($"а) Общая сумма проданного: {totalRevenue:F2} долларов");

            Console.WriteLine($"б) Самый продаваемый телефон: {bestSeller.Item1} ({bestSeller.Item2} штук)");
            Console.WriteLine($"   Наименее продаваемый телефон: {worstSeller.Item1} ({worstSeller.Item2} штук)");

            Console.WriteLine($"в) Два самых прибыльных телефона:");
            foreach (var phone in topProfitPhones)
            {
                Console.WriteLine($"   - {phone.Item1}: {phone.Item2:F2} долларов прибыли");
            }

            Console.WriteLine("Детализация продаж:");
            Console.WriteLine("Дата\t\tМодель\t\t\tКол-во\tВыручка");
            Console.WriteLine();

            foreach (var sale in sales)
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}    {sale.PhoneModel.PadRight(28)} {sale.Quantity}      {sale.TotalRevenue:F2} долларов");
            }
        }
    }
}
