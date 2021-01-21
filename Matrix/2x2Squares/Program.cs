using System;
using System.Linq;

namespace _2x2Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            int counter = 0;


            for (int row = 0; row < rows; row++)
            {
                string[] current = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(current[col]);
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if(matrix[i,j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j]
                        && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }               
            }

            Console.WriteLine(counter);
            
        }
    }
}
