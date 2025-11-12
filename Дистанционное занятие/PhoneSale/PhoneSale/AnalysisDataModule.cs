using System;
using System.Collections.Generic;

namespace PhoneShop
{
    public class AnalysisDataModule
    {
        static public List<PhoneSale> GetSalesByPeriod(List<PhoneSale> sales, DateTime startDate, DateTime endDate)
        {
            var result = new List<PhoneSale>();
            foreach (var sale in sales)
            {
                if (sale.Date >= startDate && sale.Date <= endDate)
                    result.Add(sale);
            }
            return result;
        }
    }
}
