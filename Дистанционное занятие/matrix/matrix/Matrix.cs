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

        //Вычисление детерминанта 
    }
}
