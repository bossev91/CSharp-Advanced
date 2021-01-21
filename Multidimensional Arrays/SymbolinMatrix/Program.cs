using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            bool isFound = false;

            char[,] matrix = new char[size, size];

            ReadMatrix(size, size, matrix);

            char searchedSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(matrix[row,col] == searchedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }
            }
            if(!isFound)
            {
                Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
            }
            
        }



        public static void ReadMatrix(int rows, int cols, char[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                char[] currentElement = Console.ReadLine().ToCharArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentElement[j];

                }
            }
        }
    }
}


