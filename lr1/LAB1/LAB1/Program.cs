using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
     class Program
    {
        static void Main()
        {
            // Вариант 1 Рыжов Арсений 
            Console.WriteLine("Введите размер массива: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Length]; /// даю возможность ввести размер массива
            Console.WriteLine("Введите элемент массива:");
            for (int i = 0; i < Length; i++) /// даю возможность ввести значения для массива
        }
    }
}
