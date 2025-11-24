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
    }
}
