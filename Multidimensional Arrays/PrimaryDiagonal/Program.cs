using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int sum = 0;

            int[,] matrix = new int[size, size];

            ReadMatrix(size, size, matrix);

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                   if(row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sum);
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


