using System;
using System.Linq;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCommads = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int playerRow = -1;
            int playerCol = -1;
            bool isWiner = false;

            for (int row = 0; row < size; row++)
            {
                char[] fillMatrix = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = fillMatrix[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            for (int i = 0; i < countOfCommads; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (playerRow == 0)
                    {
                        if (matrix[playerRow + size - 1, playerCol] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow + size - 1, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow = size - 2;
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                isWiner = true;
                                break;
                            }
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow + size - 1, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow = size - 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow = size - 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        if (matrix[playerRow - 1, playerCol] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow - 1, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow -= 2;

                            if (playerRow < 0)
                            {
                                playerRow = size - 1;
                            }

                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow - 1, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow -= 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow -= 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                }
                else if (command == "down")
                {
                    if (playerRow == size - 1)
                    {
                        if (matrix[playerRow - size + 1, playerCol] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow - size + 1, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow = 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow - size + 1, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow = size - 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow = 0;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        if (matrix[playerRow + 1, playerCol] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow += 2;
                            if (playerRow > size - 1)
                            {
                                playerRow = 0;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                isWiner = true;
                                break;
                            }
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow += 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow += 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                }
                else if (command == "left")
                {
                    if (playerCol == 0)
                    {
                        if (matrix[playerRow, playerCol + size - 1] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow, playerCol + size - 1] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol = size - 2;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol + size - 1] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol = size - 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol = size -1 ;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        if (matrix[playerRow , playerCol - 1] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow , playerCol - 1] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol -= 2;
                            if (playerCol < 0)
                            {
                                playerCol = size - 1;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                isWiner = true;
                                break;
                            }
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow , playerCol - 1] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol -= 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol -= 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    
                }
                else if (command == "right")
                {
                    if (playerCol == size - 1)
                    {
                        if (matrix[playerRow, playerCol - size + 1] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow, playerCol - size + 1] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol = 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol - size + 1] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol = 0;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol = 0;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        if (matrix[playerRow, playerCol + 1] == 'T')
                        {
                            // Do nothing
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'B')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol += 2;
                            if (playerCol > size - 1)
                            {
                                playerCol = 0;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                isWiner = true;
                                break;
                            }
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'F')
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol += 1;
                            matrix[playerRow, playerCol] = 'f';
                            isWiner = true;
                            break;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol += 1;
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                }            
            }
            if(isWiner)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int k = 0; k < size; k++)
            {

                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[k, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

