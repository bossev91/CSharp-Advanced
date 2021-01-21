using System;

namespace MethodsForMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);

                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] currentElement = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentElement[col];
                }
            }
        }
    }
}
