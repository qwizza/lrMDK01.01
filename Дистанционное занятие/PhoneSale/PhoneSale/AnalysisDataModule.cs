using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PhoneShop
{
    public class AnalysisDataModule
    {
        static public List<PhoneSales> GetSalesByPeriod(List<PhoneSales> sales, DateTime startDate, DateTime endDate)
        {
            var result = new List<PhoneSales>();
            foreach (var sale in sales)
            {
                if (sale.Date >= startDate && sale.Date <= endDate)
                    result.Add(sale);
            }
            return result;
        }
        static public (string, int) FindBestSeller(List<PhoneSales> sales)
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
        static public (string, int) FindWorstSeller(List<PhoneSales> sales)
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
        static public List<(string, double)> FindTopProfitPhones(List<PhoneSales> sales, int count)
        {
            var phoneProfits = new Dictionary<string, double>();

            foreach (var sale in sales)
            {
                if (phoneProfits.ContainsKey(sale.PhoneModel))
                    phoneProfits[sale.PhoneModel] += sale.TotalProfit;
                else
                    phoneProfits[sale.PhoneModel] = sale.TotalProfit;
            }

            var sortedPhones = new List<(string, double)>();
            foreach (var phone in phoneProfits)
                sortedPhones.Add((phone.Key, phone.Value));

            for (int i = 0; i < sortedPhones.Count - 1; i++)
            {
                for (int j = 0; j < sortedPhones.Count - 1 - i; j++)
                {
                    if (sortedPhones[j].Item2 < sortedPhones[j + 1].Item2)
                    {
                        var temp = sortedPhones[j];
                        sortedPhones[j] = sortedPhones[j + 1];
                        sortedPhones[j + 1] = temp;
                    }
                }
            }

            var result = new List<(string, double)>();
            for (int i = 0; i < Math.Min(count, sortedPhones.Count); i++)
                result.Add(sortedPhones[i]);

            return result;
        }
        static public double CalculateTotalRevenue(List<PhoneSales> sales)
        {
            double total = 0;
            foreach (var sale in sales)
                total += sale.TotalRevenue;
            return total;
        }

        
    }
}
