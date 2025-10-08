using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2 Рыжов Арсений
            int[] Array = new int[1000];
            Random rand = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(-500, 501); //ввел границы рандомных чисел от -500 по 500 включительно
            }

            List<int> list = new List<int>();
        }
    }
}
