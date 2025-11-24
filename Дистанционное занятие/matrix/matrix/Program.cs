using System;
using System.Diagnostics.CodeAnalysis;

namespace matrix
{
    internal class Program
    {
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            //проверка возможности умножения
            if (a.GetColumns() != b.GetColumns())
            {
                Console.WriteLine("Нельзя умножить, т.к. столбцы первой не равны строки второй");
                return null;
            }
            //создал матрицу-результата
            Matrix result = new Matrix(a.GetColumns(), b.GetColumns());

            //создал цикл умножения
            for (int i = 0; i < a.GetRows(); i++) //по сторокам а
            { 
                for(int j =  0; j < b.GetColumns(); j++) //по сторока b
                {
                    int sum = 0; // Сумма для ячейки [i,j]
                    for (int k = 0; k < a.GetColumns(); k++) //по элементам строки и столбца
                    {
                        sum += a.GetValue(i, k) * b.GetValue(k, j);
                    }
                    result.SetValue(i, j, sum);
                }
            }
            return result;
            
        }

        //создания матриц из входных данных
        public static Matrix CreateMatrixFromInput()
        {

        }

        static void Main()
        {
            
        }
    }
}
