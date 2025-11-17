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
                    if (modelSales.ContainsKey(phone.model))
                    {
                        modelSales[phone.model] += phone.countSell;
                    }
                    else
                    {
                        modelSales.Add(phone.model, phone.countSell);
                        weekSales.Add(phone.model, new int[4]);
                    }

                    weekSales[phone.model][phone.week - 1] = phone.countSell;
                }
            }

            if (modelSales.Count == 0)
            {
                Console.WriteLine("Такого бренда нету в магазине");
                return;
            }
        }
    }
}
