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
            int maxSum = 0;
            int upLeft = 0;
            int upRight = 0;
            int downLeft = 0;
            int downRight = 0;

            int[,] matrix = new int[rows, cols];


            ReadMatrix(rows, cols, matrix);

            for (int row = 0; row < rows - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < cols - 1; col++)
                {
                    sum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        upLeft = matrix[row, col];
                        upRight = matrix[row, col + 1];
                        downLeft = matrix[row + 1, col];
                        downRight =  matrix[row + 1, col + 1];
                    }
                    

                }
                
            }
            Console.WriteLine($"{upLeft} {upRight}");
            Console.WriteLine($"{downLeft} {downRight}");
            Console.WriteLine(maxSum);
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


