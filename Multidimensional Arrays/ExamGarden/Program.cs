using System;
using System.Linq;

namespace ExamGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int mRows = matrixSize[0];
            int mCols = matrixSize[1];

            int[,] matrix = new int[mRows, mCols];

            for (int row = 0; row < mRows; row++)
            {              
                for (int col = 0; col < mCols; col++)
                {
                    matrix[row, col] = 0;                    
                }
                
            }


            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                int[] cmd = command.Split().Select(int.Parse).ToArray();
                int curRow = cmd[0];
                int curCol = cmd[1];

                if(isOutOfRange(curRow, curCol, mRows))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    for (int row = 0; row < mRows; row++)
                    {
                        for (int col = 0; col < mCols; col++)
                        {
                            if(row == curRow)
                            {
                                matrix[row, col]++;
                            }
                            if (col == curCol)
                            {
                                matrix[row, col]++;
                            }
                        }
                    }
                    matrix[curRow, curCol] -= 1;
                }
               
                command = Console.ReadLine();
            }

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mCols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool isOutOfRange(int curRow, int curCol, int mRows)
        {
            return curRow < 0 || curRow >= mRows || curCol < 0 || curCol >= mRows;
        }


    }
}
