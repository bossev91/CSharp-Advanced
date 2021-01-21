using System;
using System.Linq;

namespace SwapMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parms = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[parms[0], parms[1]];

            // fillMatrix

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = data[cols];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmdArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int firstRow = int.Parse(cmdArg[1]);
                int firstCol = int.Parse(cmdArg[2]);
                int secRow = int.Parse(cmdArg[3]);
                int secCol = int.Parse(cmdArg[4]);

                if (cmdArg[0] != "swap" || cmdArg.Length > 5 || firstRow < 0 || firstRow >= matrix.GetLength(0)
                        || firstCol < 0 || firstCol >= matrix.GetLength(1)
                        || secRow < 0 || secRow >= matrix.GetLength(0)
                        || secCol < 0 || secCol >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");

                }
                else
                {


                    string elemenToSwap = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secRow, secCol];
                    matrix[secRow, secCol] = elemenToSwap;

                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            Console.Write(matrix[rows, cols] + " ");
                        }
                        Console.WriteLine();
                    }

                }
            }

            input = Console.ReadLine();
        }



    }


    
}
