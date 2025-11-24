using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Function
    {
        // а) Определить общую сумму проданного за период X
        public static double GetTotalSalesInPeriod(List<Phone> phones, DateTime startDate, DateTime endDate)
        {
            double total = 0;

            for (int i = 0; i < phones.Count; i++)
            {
                if (phones[i].date >= startDate && phones[i].date <= endDate)
                {
                    total += phones[i].countSell * phones[i].price;
                }
            }

            return total;
        }

        // б) Определить самый продаваемый телефон и телефон с наименьшим фактом продаж
        public static void FindBestSellingPhone(List<Phone> phones, DateTime startDate, DateTime endDate)
        {
            string bestPhone = "";
            int bestCount = 0;

            foreach (Phone phone in phones)
            {
                if (phone.date >= startDate && phone.date <= endDate)
                {
                    if (phone.countSell > bestCount)
                    {
                        bestCount = phone.countSell;
                        bestPhone = phone.brand + " " + phone.model;
                    }
                }
            }

            if (bestCount == 0)
            {
                Console.WriteLine("Не было продаж");
            }
            else
            {
                Console.WriteLine("Самый продаваемый: " + bestPhone);
                Console.WriteLine($"Количество: {bestCount} шт.");
            }
        }

        // в) Определить два телефона, приносящие наибольшую прибыль
        public static void FindTopTwoProfitablePhones(List<Phone> phones, DateTime startDate, DateTime endDate)
        {
            List<string> phoneNames = new List<string>();
            List<double> phoneProfits = new List<double>();

            foreach (Phone phone in phones)
            {
                if (phone.date >= startDate && phone.date <= endDate)
                {
                    string phoneName = phone.brand + " " + phone.model;
                    double profit = phone.countSell * (phone.price - phone.cost);

                    bool found = false;
                    for (int i = 0; i < phoneNames.Count; i++)
                    {
                        if (phoneNames[i] == phoneName)
                        {
                            phoneProfits[i] += profit;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        phoneNames.Add(phoneName);
                        phoneProfits.Add(profit);
                    }
                }
            }

            if (phoneNames.Count == 0)
            {
                Console.WriteLine("Нет данных о прибыли за указанный период");
                return;
            }

            string bestPhone1 = "";
            double bestProfit1 = 0;
            string bestPhone2 = "";
            double bestProfit2 = 0;

            for (int i = 0; i < phoneNames.Count; i++)
            {
                if (phoneProfits[i] > bestProfit1)
                {
                    bestProfit2 = bestProfit1;
                    bestPhone2 = bestPhone1;

                    bestProfit1 = phoneProfits[i];
                    bestPhone1 = phoneNames[i];
                }
                else if (phoneProfits[i] > bestProfit2)
                {
                    bestProfit2 = phoneProfits[i];
                    bestPhone2 = phoneNames[i];
                }
            }

            // Выводим результаты
            Console.WriteLine("Два самых прибыльных телефона:");
            Console.WriteLine($"1.{bestPhone1} - прибыль: {bestProfit1.ToString("F2")} руб.");

            if (bestProfit2 > 0)
            {
                Console.WriteLine($"2.{bestPhone2} - прибыль: {bestProfit2.ToString("F2")} руб.");
            }
        }

        
    }
}
    