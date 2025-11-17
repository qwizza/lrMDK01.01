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

            Dictionary<string, Dictionary<int, int>> weeklySales = new Dictionary<string, Dictionary<int, int>>();
        }
    }
}
