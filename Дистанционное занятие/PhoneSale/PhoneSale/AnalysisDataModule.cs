using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
        static public (string, int) FindBestSeller(List<PhoneSale> sales)
        {
            var phoneSales = new Dictionary<string, int>();

            foreach (var sale in sales)
            {
                if (phoneSales.ContainsKey(sale.PhoneModel))
                    phoneSales[sale.PhoneModel] += sale.Quantity;
                else
                    phoneSales[sale.PhoneModel] = sale.Quantity;
            }

            string bestModel = "";
            int maxSales = 0;
            foreach (var phone in phoneSales)
            {
                if (phone.Value > maxSales)
                {
                    maxSales = phone.Value;
                    bestModel = phone.Key;
                }
            }

            return (bestModel, maxSales);
        }
        static public (string, int) FindWorstSeller(List<PhoneSale> sales)
        {
            var phoneSales = new Dictionary<string, int>();

            foreach (var sale in sales)
            {
                if (phoneSales.ContainsKey(sale.PhoneModel))
                    phoneSales[sale.PhoneModel] += sale.Quantity;
                else
                    phoneSales[sale.PhoneModel] = sale.Quantity;
            }

            string worstModel = "";
            int minSales = int.MaxValue;
            foreach (var phone in phoneSales)
            {
                if (phone.Value < minSales)
                {
                    minSales = phone.Value;
                    worstModel = phone.Key;
                }
            }

            return (worstModel, minSales);
        }
        static public List<(string, double)> FindTopProfitPhones(List<PhoneSale> sales, int count)
        {
            var phoneProfits = new Dictionary<string, double>();

            foreach (var sale in sales)
            {
                if (phoneProfits.ContainsKey(sale.PhoneModel))
                    phoneProfits[sale.PhoneModel] += sale.TotalProfit;
                else
                    phoneProfits[sale.PhoneModel] = sale.TotalProfit;
            }
        }
}
