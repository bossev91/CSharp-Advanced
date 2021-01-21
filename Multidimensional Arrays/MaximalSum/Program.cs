using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long rows = input[0];
            long cols = input[1];
            long[,] matrix = new long[rows, cols];
            long max = int.MinValue;
            long maxRow = -1;
            long maxCol = -1;


            for (int row = 0; row < rows; row++)
            {
                long[] current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            for (int row = 0 ; row < rows - 2 ; row++)
            {
                for (int col = 0; col < cols -2  ; col++)
                {
                    long curSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if(curSum > max)
                    {
                        max = curSum;
                        maxRow = row;
                        maxCol = col;
                        
                    }
                    
                }
            }
            Console.WriteLine($"Sum = {max}");
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");

        }
    }
}
