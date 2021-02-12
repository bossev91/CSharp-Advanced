using System;

namespace ExamReVoltShort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCmds = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int playerRow = -1;
            int playerCol = -1;
            bool isWiner = false;
            fillMatrix(size, matrix, ref playerRow, ref playerCol);
            

            for (int i = 0; i < countOfCmds; i++)
            {
                matrix[playerRow, playerCol] = '-';
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        playerRow--;
                        if (!IsInRange(size, playerRow, playerCol))
                        {
                            playerRow = size - 1;
                            if (matrix[playerRow, playerCol] == 'B')
                            {
                                playerRow = size - 2;
                            }
                        }
                        else if(matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow--;
                            if (!IsInRange(size, playerRow, playerCol))
                            {
                                playerRow = size - 1;
                            }
                        }
                        else if(matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow++;
                        }
                        break;
                    case "down":
                        playerRow++;
                        if (!IsInRange(size, playerRow, playerCol))
                        {
                            playerRow = 0;
                            if (matrix[playerRow, playerCol] == 'B')
                            {
                                playerRow = 1;
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow++;
                            if (!IsInRange(size, playerRow, playerCol))
                            {
                                playerRow = 0;
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow--;
                        }
                        break;
                    case "left":
                        playerCol--;
                        if (!IsInRange(size, playerRow, playerCol))
                        {
                            playerCol = size - 1;
                            if (matrix[playerRow, playerCol] == 'B')
                            {
                                playerCol = size - 2;
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol--;
                            if (!IsInRange(size, playerRow, playerCol))
                            {
                                playerCol = size - 1;
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol++;
                        }
                        break;
                    case "right":
                        playerCol++;
                        if (!IsInRange(size, playerRow, playerCol))
                        {
                            playerCol = 0;
                            if (matrix[playerRow, playerCol] == 'B')
                            {
                                playerCol = 1;
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol++;
                            if (!IsInRange(size, playerRow, playerCol))
                            {
                                playerCol = 0;
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol--;
                        }
                        break;                      
                }
                if(matrix[playerRow, playerCol] == 'F')
                {
                    isWiner = true;
                    matrix[playerRow, playerCol] = 'f';
                    break;
                }
                matrix[playerRow, playerCol] = 'f';
               // PrintMatrix(size, matrix);
                // end of loop
            }
            if(isWiner)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(size, matrix);
        }

        private static void PrintMatrix(int size, char[,] matrix)
        {
            for (int k = 0; k < size; k++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[k, j]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsInRange(int size, int playerRow, int playerCol)
        {
            return playerRow >= 0 && playerRow < size && playerCol >= 0 && playerCol < size;
        }
        private static void fillMatrix(int size, char[,] matrix, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < size; row++)
            {
                char[] current = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = current[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
