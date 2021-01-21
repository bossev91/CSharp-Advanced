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
            
            int[,] matrix = new int[rows, cols];

            ReadMatrix(rows, cols, matrix);

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }

        public static void ReadMatrix(int rows, int cols, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                int[] currentElement = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentElement[j];

                }
            }
        }
    }
}


