using PhoneShop;
using System;
using System.Collections.Generic;

namespace PhoneSale
{
    internal class Program
    {
        static void Main()
        {
            List<PhoneSale> sales = InputModule.CreateSalesData();

            DateTime startDate = new DateTime(2025, 11, 10);
            DateTime endDate = new DateTime(2025, 11, 13);

            List<PhoneSale> periodSales = AnalysisDataModule.GetSalesByPeriod(sales, startDate, endDate);
        }
    }
}
