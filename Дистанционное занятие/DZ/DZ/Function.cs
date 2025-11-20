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
            double totalRevenue = 0;

            foreach (Phone phone in phones)
            {
                if (phone.date >= startDate && phone.date <= endDate)
                {
                    totalRevenue += phone.countSell * phone.price;
                }
            }

            return totalRevenue;
        }

        // б) Определить самый продаваемый телефон и телефон с наименьшим фактом продаж
        public static void GetBestAndWorstSellingPhones(List<Phone> phones, DateTime startDate, DateTime endDate)
        {
            Dictionary<string, int> phoneSales = new Dictionary<string, int>();

            foreach (Phone phone in phones)
            {
                if (phone.date >= startDate && phone.date <= endDate)
                {
                    string phoneKey = $"{phone.brand} {phone.model}";

                    if (phoneSales.ContainsKey(phoneKey))
                    {
                        phoneSales[phoneKey] += phone.countSell;
                    }
                    else
                    {
                        phoneSales.Add(phoneKey, phone.countSell);
                    }
                }
            }

            if (phoneSales.Count == 0)
            {
                Console.WriteLine("Нет данных о продажах за указанный период");
                return;
            }

            var bestSelling = phoneSales.OrderByDescending(x => x.Value).First();
            var worstSelling = phoneSales.OrderBy(x => x.Value).First();

            Console.WriteLine($"Самый продаваемый телефон: {bestSelling.Key} - {bestSelling.Value} шт.");
            Console.WriteLine($"Телефон с наименьшими продажами: {worstSelling.Key} - {worstSelling.Value} шт.");
        }

        // в) Определить два телефона, приносящие наибольшую прибыль
        public static void GetTopTwoProfitablePhones(List<Phone> phones, DateTime startDate, DateTime endDate)
        {
            Dictionary<string, double> phoneProfits = new Dictionary<string, double>();

            foreach (Phone phone in phones)
            {
                if (phone.date >= startDate && phone.date <= endDate)
                {
                    string phoneKey = $"{phone.brand} {phone.model}";
                    double profit = phone.countSell * (phone.price - phone.cost);

                    if (phoneProfits.ContainsKey(phoneKey))
                    {
                        phoneProfits[phoneKey] += profit;
                    }
                    else
                    {
                        phoneProfits.Add(phoneKey, profit);
                    }
                }
            }

            if (phoneProfits.Count == 0)
            {
                Console.WriteLine("Нет данных о прибыли за указанный период");
                return;
            }

            var topTwo = phoneProfits.OrderByDescending(x => x.Value).Take(2);

            Console.WriteLine("Два самых прибыльных телефона:");
            int rank = 1;
            foreach (var phone in topTwo)
            {
                Console.WriteLine($"{rank}. {phone.Key} - прибыль: {phone.Value:F2} руб.");
                rank++;
            }
        }

        // Вспомогательный метод для отображения всех продаж
        public static void ShowAllSales(List<Phone> phones)
        {
            Console.WriteLine("Все данные о продажах:");
            Console.WriteLine("Дата\t\tБренд\tМодель\t\tКол-во\tЦена\t\tСебест.\t\tПрибыль");
            Console.WriteLine(new string('-', 80));

            foreach (var phone in phones.OrderBy(p => p.date))
            {
                double profit = phone.countSell * (phone.price - phone.cost);
                Console.WriteLine($"{phone.date:dd.MM.yyyy}\t{phone.brand}\t{phone.model,-10}\t{phone.countSell}\t{phone.price:F2}\t\t{phone.cost:F2}\t\t{profit:F2}");
            }
        }
    }
}
