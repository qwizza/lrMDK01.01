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
    }
}
