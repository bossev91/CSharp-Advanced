using System;
using System.Linq;

namespace ExamBee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int beeRow = -1;
            int beeCol = -1;
            int colectedFlowers = 0;
            bool isGotLost = false;
            FillMatrix(size, matrix, ref beeRow, ref beeCol);

            //bool IsInRange = beeRow >= 0 && beeRow < size && beeCol >= 0 && beeCol <= size;

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "up")
                {
                    if (IsInRange(beeRow - 1, beeCol, size))
                    {
                        if (matrix[beeRow - 1, beeCol] == 'f')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeRow -= 1;
                            matrix[beeRow, beeCol] = 'B';
                            colectedFlowers++;
                        }
                        else if (matrix[beeRow - 1, beeCol] == 'O')
                        {
                            if (IsInRange(beeRow - 2, beeCol, size))
                            {
                                matrix[beeRow - 1, beeCol] = '.';
                                matrix[beeRow, beeCol] = '.';
                                if (matrix[beeRow - 2, beeCol] == 'f')
                                {
                                    colectedFlowers++;
                                }
                                beeRow -= 2;
                                matrix[beeRow, beeCol] = 'B';
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = '.';
                                isGotLost = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeRow -= 1;
                            matrix[beeRow, beeCol] = 'B';
                        }
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        isGotLost = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (IsInRange(beeRow + 1, beeCol, size))
                    {
                        if (matrix[beeRow + 1, beeCol] == 'f')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeRow += 1;
                            matrix[beeRow, beeCol] = 'B';
                            colectedFlowers++;
                        }
                        else if (matrix[beeRow + 1, beeCol] == 'O')
                        {
                            if (IsInRange(beeRow + 2, beeCol, size))
                            {
                                matrix[beeRow + 1, beeCol] = '.';
                                matrix[beeRow, beeCol] = '.';
                                if (matrix[beeRow + 2, beeCol] == 'f')
                                {
                                    colectedFlowers++;
                                }
                                beeRow += 2;
                                matrix[beeRow, beeCol] = 'B';
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = '.';
                                isGotLost = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeRow += 1;
                            matrix[beeRow, beeCol] = 'B';
                        }
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        isGotLost = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (IsInRange(beeRow , beeCol - 1, size))
                    {
                        if (matrix[beeRow , beeCol - 1] == 'f')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeCol -= 1;
                            matrix[beeRow, beeCol] = 'B';
                            colectedFlowers++;
                        }
                        else if (matrix[beeRow , beeCol - 1] == 'O')
                        {
                            if (IsInRange(beeRow , beeCol - 2, size))
                            {
                                matrix[beeRow , beeCol - 1] = '.';
                                matrix[beeRow, beeCol] = '.';
                                if (matrix[beeRow , beeCol - 2] == 'f')
                                {
                                    colectedFlowers++;
                                }
                                beeCol -= 2;
                                matrix[beeRow, beeCol] = 'B';
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = '.';
                                isGotLost = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeCol -= 1;
                            matrix[beeRow, beeCol] = 'B';
                        }
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        isGotLost = true;
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (IsInRange(beeRow, beeCol + 1, size))
                    {
                        if (matrix[beeRow, beeCol + 1] == 'f')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeCol += 1;
                            matrix[beeRow, beeCol] = 'B';
                            colectedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol + 1] == 'O')
                        {
                            if (IsInRange(beeRow, beeCol + 2, size))
                            {
                                matrix[beeRow, beeCol + 1] = '.';
                                matrix[beeRow, beeCol] = '.';

                                if (matrix[beeRow, beeCol + 2] == 'f')
                                {
                                    colectedFlowers++;
                                }
                                beeCol += 2;
                                matrix[beeRow, beeCol] = 'B';
                            }
                            else
                            {
                                matrix[beeRow, beeCol] = '.';
                                isGotLost = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeCol += 1;
                            matrix[beeRow, beeCol] = 'B';
                        }
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = '.';
                        isGotLost = true;
                        break;
                    }
                }
               // PrintMatrix(size, matrix);
                command = Console.ReadLine();
            }
            if(isGotLost)
            {
                Console.WriteLine("The bee got lost!");
            }
            if(colectedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {colectedFlowers} flowers!");               
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - colectedFlowers} flowers more");
            }
            PrintMatrix(size, matrix);
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

        private static void FillMatrix(int size, char[,] matrix, ref int beeRow, ref int beeCol)
        {
            for (int row = 0; row < size; row++)
            {
                var currentElement = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentElement[col];
                    if (currentElement[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
        }
        private static bool IsInRange(int beeRow, int beeCol, int size)
        {
            return beeRow >= 0 && beeRow < size && beeCol >= 0 && beeCol < size;
        }
    }
}
