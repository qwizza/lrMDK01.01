using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_12
{
    class Function
    {
        public static void ShowTopPhones(List<Phone> phones)
        {
            Console.WriteLine("Введите марку телефона (iPhone, Samsung, Huawei): ");
            string brand = Console.ReadLine();

            Dictionary<string, int> totalSales = new Dictionary<string, int>();

            Dictionary<string, int[]> weekSales = new Dictionary<string, int[]>();

            foreach (Phone phone in phones)
            {
                if (phone.brand == brand)
                {
                    if (totalSales.ContainsKey(phone.model))
                    {
                        totalSales[phone.model] += phone.countSell;
                    }
                    else
                    {
                        totalSales.Add(phone.model, phone.countSell);
                        weekSales.Add(phone.model, new int[4]);
                    }

                    weekSales[phone.model][phone.week - 1] = phone.countSell;
                }
            }

            if (totalSales.Count == 0)
            {
                Console.WriteLine("Такого бренда нету в магазине");
                return;
            }
            string[] modelName = new string[totalSales.Count];
            totalSales.Keys.CopyTo(modelName, 0);

            for (int i = 0; i < modelName.Length - 1; i++)
            {
                for (int j = 0; j < modelName.Length - 1 - i; j++)
                {
                    double sales1 = (double)totalSales[modelName[j]] / 4;
                    double sales2 = (double)totalSales[modelName[j + 1]] / 4;

                    if (sales1 < sales2)
                    {
                        string temp = modelName[j];
                        modelName[j] = modelName[j + 1];
                        modelName[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"\n{brand} - самые популярные модели:");

            for (int i = 0; i < modelName.Length; i++)
            {
                string model = modelName[i];
                double average = (double)totalSales[model] / 4;

                Console.WriteLine($"{i + 1}. {model}");
                Console.WriteLine($"   Средние продажи: {average:F1} шт/неделю");
                Console.WriteLine($"   Всего продано: {totalSales[model]} шт");
            }
        }
    }
}
