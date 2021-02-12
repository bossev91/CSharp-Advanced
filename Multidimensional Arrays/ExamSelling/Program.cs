using System;

namespace ExamSelling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int cRow = -1;
            int cCol = -1;
            fillMatrix(size, matrix, ref cRow, ref cCol);
            int sumColected = 0;
            bool isComplete = true;

            while (sumColected < 50)
            {
                matrix[cRow, cCol] = '-';
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        cRow--;
                        break;
                    case "down":
                        cRow++;
                        break;
                    case "left":
                        cCol--;
                        break;
                    case "right":
                        cCol++;
                        break;
                }
                if(isOut(size, cRow, cCol))
                {
                    isComplete = false;
                    break;
                }
                else
                {
                    char current = matrix[cRow, cCol];                    
                    if (char.IsDigit(current))
                    {
                        int sw = int.Parse(current.ToString());
                        sumColected += sw;
                    }
                    else if (current == 'O')
                    {
                        matrix[cRow, cCol] = '-';
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if(matrix[i,j] == 'O')
                                {
                                    cRow = i;
                                    cCol = j;
                                }
                            }
                        }
                    }
                   
                }

                matrix[cRow, cCol] = 'S';

            }

            if(isComplete)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            else
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {sumColected}");
             PrintMatrix(size, matrix);

            isOut(size, cRow, cCol);
        }

        private static bool isOut(int size, int cRow, int cCol)
        {
            return cRow < 0 || cRow >= size || cCol < 0 || cCol >= size;
        }

        private static void fillMatrix(int size, char[,] matrix, ref int cRow, ref int cCol)
        {
            for (int row = 0; row < size; row++)
            {
                char[] current = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = current[col];
                    if (matrix[row, col] == 'S')
                    {
                        cRow = row;
                        cCol = col;
                    }
                }
            }
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

    }
}
