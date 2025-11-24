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
            Console.Write("Введите кол-во строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            //создание пустой матрицы
            Matrix matrix = new Matrix(rows, columns);

            Console.WriteLine($"Введите значения для матрицы {rows}x{columns}:");
            //заполнение матрицы
            for (int i = 0; i < rows; i++) //перебирает строки
            {
                for (int j = 0; j < columns; j++) //перебирает столбцы
                {
                    //ввод каждого эллемента
                    Console.Write($"Элемент [{i},{j}]: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    matrix.SetValue(i, j, value); //запись числа в матрицу
                }
            }

            return matrix;
        }

        static void Main()
        {
            Console.WriteLine("Создание первой матрицы");
            Matrix matrix1 = CreateMatrixFromInput(); //создание первой матрицы 

            Console.WriteLine("Ваша первая матрицы: ");
            matrix1.Print();

            if (matrix1.IsSquare()) //проверка на квадратность и поиск детерминанта
            {
                Console.WriteLine($"Определитель: {matrix1.Determinant()}");
            }
        }
    }
}
