using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];
            int marioRow = -1;
            int marioCol = -1;
            bool winGame = false;

            for (int row = 0; row < matrix.Length; row++)
            {
                char[] current = Console.ReadLine().ToCharArray();
                matrix[row] = current;
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (current[col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            while (lives > 0)
            {
                matrix[marioRow][marioCol] = '-';
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string move = cmdArgs[0];
                int spawnRow = int.Parse(cmdArgs[1]);
                int spawnCol = int.Parse(cmdArgs[2]);
                matrix[spawnRow][spawnCol] = 'B';

                if (move == "W") // Up
                {
                    if (IsValid(matrix, marioRow - 1, marioCol))
                    {
                        marioRow--;
                    }
                }
                else if (move == "S") // Down
                {
                    if (IsValid(matrix, marioRow + 1, marioCol))
                    {
                        marioRow++;
                    }
                }
                else if (move == "A") // Left
                {
                    if (IsValid(matrix, marioRow, marioCol - 1))
                    {
                        marioCol--;
                    }
                }
                else if (move == "D")  // Right
                {
                    if (IsValid(matrix, marioRow, marioCol + 1))
                    {
                        marioCol++;
                    }
                }
                lives--;

                if (matrix[marioRow][marioCol] == 'P')
                {
                    winGame = true;
                    matrix[marioRow][marioCol] = '-';
                    break;
                }
                if (matrix[marioRow][marioCol] == 'B')
                {
                    lives -= 2;
                }
                if (lives <= 0)
                {
                    matrix[marioRow][marioCol] = 'X';
                    break;
                }

                matrix[marioRow][marioCol] = 'M';

            }

            if (winGame)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
            }

            PrintMatrix(matrix);
        }
        private static bool IsValid(char[][] matrix, int marioRow, int marioCol)
        {
            return marioRow >= 0 && marioRow < matrix.Length && marioCol >= 0 && marioCol < matrix[marioRow].Length;
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
