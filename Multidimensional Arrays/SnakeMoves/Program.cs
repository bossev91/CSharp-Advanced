using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            char[] text = Console.ReadLine().ToCharArray();
            int txtLenght = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                if(row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = text[txtLenght];

                        if (txtLenght == text.Length - 1)
                        {
                            txtLenght = 0;
                        }
                        else
                        {
                            txtLenght++;
                        }

                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = text[txtLenght];

                        if (txtLenght == text.Length - 1)
                        {
                            txtLenght = 0;
                        }
                        else
                        {
                            txtLenght++;
                        }
                    }
                }
                
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
