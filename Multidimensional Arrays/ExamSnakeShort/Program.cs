using System;

namespace ExamSnakeShort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int snakeRow = -1;
            int snakeCol = -1;
            fillMatrix(size, matrix, ref snakeRow, ref snakeCol);
            int foodЕaten = 0;
            IsInRange(size, snakeRow, snakeCol);
            bool isWinner = true;

            while (foodЕaten < 10)
            {
                matrix[snakeRow, snakeCol] = '.';
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "right":
                        snakeCol++;
                        break;
                }
                if (!IsInRange(size, snakeRow, snakeCol))
                {
                    isWinner = false;
                    break;
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    foodЕaten++;
                }
                else if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (matrix[i, j] == 'B')
                            {
                                snakeRow = i;
                                snakeCol = j;
                            }
                        }
                    }
                }
                matrix[snakeRow, snakeCol] = 'S';
            }
            if (isWinner)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
            Console.WriteLine($"Food eaten: {foodЕaten}");
            printMatrix(size, matrix);
        }

        private static bool IsInRange(int size, int snakeRow, int snakeCol)
        {
            return snakeRow >= 0 && snakeRow < size && snakeCol >= 0 && snakeCol < size;
        }

        private static void printMatrix(int size, char[,] matrix)
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

        private static void fillMatrix(int size, char[,] matrix, ref int snakeRow, ref int snakeCol)
        {
            for (int row = 0; row < size; row++)
            {
                char[] current = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = current[col];
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }
        }
    }
}
