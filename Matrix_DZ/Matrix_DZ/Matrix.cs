

using System;

namespace Matrix_DZ
{
    public class Matrix
    {
        /// Создали атрибуты класса
        private int[,] numbers;
        private int rows;
        private int cols;
        

        /// Создание матрицы
        public void CreatingMatrix (int r, int c)
        {
            rows = r;
            cols = c;
            numbers = new int[rows, cols];
        }
        ///Записываем число в саму матрицу(в ячейку)
        public void SetMatrix(int row,int col,int value)
        {
            numbers[row,col] = value;
        }
        /// Выводим число из ячейки
        public int GetMatrix(int row,int col)
        {
            return numbers[row,col];
        }
        public int GetRows()
        {
            return rows;
        }
        public int GetCols()
        {
            return cols;
        }
        /// Вывод матрицы на консоль 
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        
       


        /// Считаем определитель для матриц
        public int Determinant()
        {
            if (!(rows == cols))
            {
                Console.WriteLine("Матрица не квадратная !!! ");
                return 0;
            }
            if (rows == cols)
            {
                if (rows == 1)
                {
                    return numbers[0, 0];
                }
                if (rows == 2)
                {
                    return numbers[0, 0] * numbers[1, 1] - numbers[0, 1] * numbers[1, 0];
                }
            }
            return 0;
        }




    }
}
