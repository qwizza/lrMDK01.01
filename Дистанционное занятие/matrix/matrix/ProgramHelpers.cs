using System;

namespace matrix
{
    internal static class ProgramHelpers
    {
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            //проверка возможности умножения
            if (a.GetColumns() != b.GetColumns())
            {
                Console.WriteLine("Нельзя умножить, т.к. столбцы первой не равны строки второй");
                return null;
            }


        }
    }
}