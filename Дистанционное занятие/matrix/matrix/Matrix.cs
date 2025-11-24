using System;

namespace matrix
{
    public class Matrix
    {
        private int[,] data; //хранилище чисел матриц
        private int rows; //кол-во строк
        private int columns; //кол-во столбцов 

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }

        //метод для получения размера матриц
        public int GetRows()
        {
            return rows;
        }
        public int GetColumns()
        {
            return columns;
        }

        // метод для записи числа в ячейку матрицы
        public void SetValue(int row, int column, int value)
        {
            data[row, column] = value;
        }
        // метод для чтения числа из ячейки матрицы
        public int GetValue(int row, int column)
        {
            return data[row, column];
        }

        //проверка на квадратность
        public bool IsSquare()
        {
            return rows == columns;
        }

        //вычисление детерминанта 
        public int Determinant()
        {
            //проверяем, являится ли матрица квадратно 
            if (!IsSquare())
            {
                Console.WriteLine("Матрица не квадратная");
                return 0;
            }

            //проверка матрицы, имеет ли марица размер 1x1
            if (rows == 1)
            {
                return data[0, 0];
            }

            //проверка матрицы, имеет ли марица размер 2x2
            if (rows == 2)
            {
                int a = data[0, 0];
                int b = data[0, 1];
                int c = data[1, 0];
                int d = data[1, 1];
                return a * d - b * c;
            }

            Console.WriteLine("Определитель только для матриц 1x1 и 2x2");
            return 0;
        }

        //вывод матриц на экран
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
