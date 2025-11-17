using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> sales = new List<Phone>();
            //iPhone
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", week = 1, countSell = 1 });
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", week = 2, countSell = 0 });
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", week = 3, countSell = 0 });
            sales.Add(new Phone { brand = "iPhone", model = "17 Pro", week = 4, countSell = 2 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", week = 1, countSell = 1 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", week = 2, countSell = 3 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", week = 3, countSell = 2 });
            sales.Add(new Phone { brand = "iPhone", model = "16 Pro", week = 4, countSell = 4 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", week = 1, countSell = 2 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", week = 2, countSell = 5 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", week = 3, countSell = 0 });
            sales.Add(new Phone { brand = "iPhone", model = "15 Pro", week = 4, countSell = 1 });
            //Samsung
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", week = 1, countSell = 1 });
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", week = 2, countSell = 0 });
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", week = 3, countSell = 3 });
            sales.Add(new Phone { brand = "Samsung", model = "S25 Ultra", week = 4, countSell = 4 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", week = 1, countSell = 0 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", week = 2, countSell = 0 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", week = 3, countSell = 2 });
            sales.Add(new Phone { brand = "Samsung", model = "S24 Ultra", week = 4, countSell = 3 });
            sales.Add(new Phone { brand = "Samsung", model = "S25+", week = 1, countSell = 2 });
            sales.Add(new Phone { brand = "Samsung", model = "S25+", week = 2, countSell = 0 });
            sales.Add(new Phone { brand = "Samsung", model = "S25+", week = 3, countSell = 3 });
            sales.Add(new Phone { brand = "Samsung", model = "S25+", week = 4, countSell = 4 });
            //Huawei
            sales.Add(new Phone { brand = "Huawei", model = "P60 Pro", week = 1, countSell = 4 });
            sales.Add(new Phone { brand = "Huawei", model = "P60 Pro", week = 2, countSell = 3 });
            sales.Add(new Phone { brand = "Huawei", model = "P60 Pro", week = 3, countSell = 5 });
            sales.Add(new Phone { brand = "Huawei", model = "P60 Pro", week = 4, countSell = 2 });
            sales.Add(new Phone { brand = "Huawei", model = "Mate 50", week = 1, countSell = 2 });
            sales.Add(new Phone { brand = "Huawei", model = "Mate 50", week = 2, countSell = 1 });
            sales.Add(new Phone { brand = "Huawei", model = "Mate 50", week = 3, countSell = 0 });
            sales.Add(new Phone { brand = "Huawei", model = "Mate 50", week = 4, countSell = 1 });
            sales.Add(new Phone { brand = "Huawei", model = "Nova 12", week = 1, countSell = 3 });
            sales.Add(new Phone { brand = "Huawei", model = "Nova 12", week = 2, countSell = 2 });
            sales.Add(new Phone { brand = "Huawei", model = "Nova 12", week = 3, countSell = 4 });
            sales.Add(new Phone { brand = "Huawei", model = "Nova 12", week = 4, countSell = 3 });

            Function.ShowTopPhones(sales);
        }
    }
}
