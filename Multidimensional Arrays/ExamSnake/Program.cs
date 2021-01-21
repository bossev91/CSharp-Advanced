using System;

namespace ExamSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int curPositionRow = -1;
            int curPositionCol = -1;
            int foodCount = 0;
            bool isComplete = true;
            ReadMatrix(n, n, matrix);
            FindElements(n, matrix, ref curPositionRow, ref curPositionCol);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "left")
                {
                    matrix[curPositionRow, curPositionCol] = '.';
                    curPositionCol -= 1;
                    if (IsValid(curPositionRow, curPositionCol, n))
                    {
                        if (matrix[curPositionRow, curPositionCol] == '*')
                        {
                            foodCount++;
                        }
                        else if (matrix[curPositionRow, curPositionCol] == 'B')
                        {
                            matrix[curPositionRow, curPositionCol] = '.';

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        curPositionRow = i;
                                        curPositionCol = j;
                                    }
                                }
                            }
                        }
                        matrix[curPositionRow, curPositionCol] = 'S';
                    }
                    else
                    {
                        isComplete = false;
                        break;
                    }

                }
                if (command == "right")
                {
                    matrix[curPositionRow, curPositionCol] = '.';
                    curPositionCol += 1;
                    if (IsValid(curPositionRow, curPositionCol, n))
                    {
                        if (matrix[curPositionRow, curPositionCol] == '*')
                        {
                            foodCount++;
                        }
                        else if (matrix[curPositionRow, curPositionCol] == 'B')
                        {
                            matrix[curPositionRow, curPositionCol] = '.';

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        curPositionRow = i;
                                        curPositionCol = j;
                                    }
                                }
                            }
                        }
                        matrix[curPositionRow, curPositionCol] = 'S';
                    }
                    else
                    {
                        isComplete = false;
                        break;
                    }

                }
                else if (command == "up")
                {
                    matrix[curPositionRow, curPositionCol] = '.';
                    curPositionRow -= 1;
                    if (IsValid(curPositionRow, curPositionCol, n))
                    {
                        if (matrix[curPositionRow, curPositionCol] == '*')
                        {
                            foodCount++;
                        }
                        else if (matrix[curPositionRow, curPositionCol] == 'B')
                        {
                            matrix[curPositionRow, curPositionCol] = '.';

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        curPositionRow = i;
                                        curPositionCol = j;
                                    }
                                }
                            }
                        }
                        matrix[curPositionRow, curPositionCol] = 'S';
                    }
                    else
                    {
                        isComplete = false;
                        break;
                    }

                }

                else if (command == "down")
                {
                    matrix[curPositionRow, curPositionCol] = '.';
                    curPositionRow += 1;
                    if (IsValid(curPositionRow, curPositionCol, n))
                    {
                        if (matrix[curPositionRow, curPositionCol] == '*')
                        {
                            foodCount++;
                        }
                        else if (matrix[curPositionRow, curPositionCol] == 'B')
                        {
                            matrix[curPositionRow, curPositionCol] = '.';

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        curPositionRow = i;
                                        curPositionCol = j;
                                    }
                                }
                            }
                        }
                        matrix[curPositionRow, curPositionCol] = 'S';
                    }
                    else
                    {
                        isComplete = false;
                        break;
                    }

                }
                PrintMatrix(n, matrix);

                if (foodCount == 10)
                {
                    break;
                }
            }
            if (!isComplete)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {foodCount}");
                PrintMatrix(n, matrix);
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
                Console.WriteLine($"Food eaten: {foodCount}");
                PrintMatrix(n, matrix);
            }
        }

        private static void FindElements(int n, char[,] matrix, ref int curPositionRow, ref int curPositionCol)
        {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    char currentElement = matrix[i, j];
                    if (currentElement == 'S')
                    {
                        curPositionRow = i;
                        curPositionCol = j;
                    }
                }
            }

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

        public static bool IsValid(int curRow, int curCol, int n)
        {
            if (curRow >= 0 && curRow < n && curCol >= 0 && curCol < n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
