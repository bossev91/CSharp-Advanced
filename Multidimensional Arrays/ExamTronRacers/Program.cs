using System;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;
            FillMatrix(size, matrix, ref firstPlayerRow, ref firstPlayerCol, ref secondPlayerRow, ref secondPlayerCol);
           

            string command = Console.ReadLine();
            while (true)
            {
                string[] cmdArg = command.Split();
                string playerOneCmd = cmdArg[0];
                string playerTwoCmd = cmdArg[1];

                switch (playerOneCmd)
                {
                    case "up":
                        firstPlayerRow--;
                        if(!IsInRange(firstPlayerRow, firstPlayerCol, size))
                        {
                            firstPlayerRow = size - 1;
                        }                       
                        break;
                    case "down":
                        firstPlayerRow++;
                        if (!IsInRange(firstPlayerRow, firstPlayerCol, size))
                        {
                            firstPlayerRow = 0;
                        }
                        break;
                    case "left":
                        firstPlayerCol--;
                        if (!IsInRange(firstPlayerRow, firstPlayerCol, size))
                        {
                            firstPlayerCol = size - 1;
                        }
                        break;
                    case "right":
                        firstPlayerCol++;
                        if (!IsInRange(firstPlayerRow, firstPlayerCol, size))
                        {
                            firstPlayerRow = 0;
                        }
                        break;
                }

                if(matrix[firstPlayerRow, firstPlayerCol] == 's')
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'x';
                    break;
                }
                else
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'f';
                }

                switch (playerTwoCmd)
                {
                    case "up":
                        secondPlayerRow--;
                        if (!IsInRange(secondPlayerRow, secondPlayerCol, size))
                        {
                            secondPlayerRow = size - 1;
                        }
                        break;
                    case "down":
                        secondPlayerRow++;
                        if (!IsInRange(secondPlayerRow, secondPlayerCol, size))
                        {
                            secondPlayerRow = 0;
                        }
                        break;
                    case "left":
                        secondPlayerCol--;
                        if (!IsInRange(secondPlayerRow, secondPlayerCol, size))
                        {
                            secondPlayerCol = size - 1;
                        }
                        break;
                    case "right":
                        secondPlayerCol++;
                        if (!IsInRange(secondPlayerRow, secondPlayerCol, size))
                        {
                            secondPlayerCol = 0;
                        }
                        break;
                }

                if (matrix[secondPlayerRow, secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 'x';
                    break;
                }
                else
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 's';
                }
                PrintMatrix(size, matrix);
                command = Console.ReadLine();
            }

            PrintMatrix(size, matrix);
        }
        public static bool IsInRange(int playerRow, int playerCol, int size)
        {
            return playerRow >= 0 && playerRow < size && playerCol >= 0 && playerCol < size;
        }
        private static void PrintMatrix(int size, char[,] matrix)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int size, char[,] matrix, ref int firstPlayerRow, ref int firstPlayerCol, ref int secondPlayerRow, ref int secondPlayerCol)
        {
            for (int row = 0; row < size; row++)
            {
                char[] current = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = current[col];
                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }
        }
    }
}
