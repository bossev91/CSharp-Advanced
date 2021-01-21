using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsNcows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsNcows[0];
            int cols = rowsNcows[1];
            int sum = 0;

            int[,] matrix = new int[rows, cols];

            ReadMatrix(rows, cols, matrix);

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            ManipulateMatrix(matrix);

        }

        private static void ManipulateMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }

        public static void ReadMatrix(int rows, int cols, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                int[] currentElement = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentElement[j];

                }
            }
        }
    }
}


