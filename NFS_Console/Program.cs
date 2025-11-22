

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace NFS_Console
{
    public class Program
    {
        static void Main()
        {
            Auto Lada = new Auto();

            Lada.SetModel("Гонечная лада");
            Lada.SetSpeed(700);
            //PrintAuto(Lada);

            Auto Tank = new Auto();

            Tank.SetModel("Танк");
            Tank.SetSpeed(100);
            //PrintAuto(Tank);

            Auto BMW = new Auto();

            BMW.SetModel("Супер быстрая БМВ");
            BMW.SetSpeed(600);
            //PrintAuto(BMW);

            Auto Audi = new Auto();

            Audi.SetModel("Ауди мега кар");
            Audi.SetSpeed(550);
            //PrintAuto(Audi);

            Auto Merc = new Auto();

            Merc.SetModel("Крутой мерседес");
            Merc.SetSpeed(500);
            //PrintAuto(Merc);

            List<Auto> cars = new List<Auto>();
            cars.Add(Lada);
            cars.Add(Tank);
            cars.Add(BMW);
            cars.Add(Audi);
            cars.Add(Merc);
            

            LadaVsMerc(cars);
           
        }

        static void LadaVsMerc(List<Auto> cars)
        {
            int f = 100;
            int t = 0;
            while (true)
            {
                foreach(Auto car in cars)
                {
                    int move = car.GetSpeed() / 50 * t;
                    for (int i = 1; i < move; i++)
                    {
                        Console.Write(" ");
                      
                    }
                    Console.WriteLine(car.GetModel());
                    Console.WriteLine("========================================================================================================");
                    if (move > f)
                    {
                        Console.Clear();
                        Console.WriteLine("Победитель - " + car.GetModel());
                        return;
                    }


                }
                t++;
                Thread.Sleep(750);
                Console.Clear();
            }
            

        }

        static void PrintAuto(Auto mashina)
        {
            Console.WriteLine(mashina.GetModel());
        }
    } 
}
