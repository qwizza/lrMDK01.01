using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            Olenivod olenivod = new Olenivod("Иванов", 20, 200000);
            Olenivod olenivod2 = new Olenivod("Сидоров", 19, 150000);
            Olenivod olenivod3 = new Olenivod("Петров", 30, 300000);
            Console.WriteLine($"Имя оленивода:{olenivod.GetName()}");

            List<Olenivod> olenivods = new List<Olenivod>();
            olenivods.Add(olenivod);
            olenivods.Add(olenivod2);
            olenivods.Add(olenivod3);
            Console.WriteLine(olenivod2.GetName()); 

        }
        
    }
}
