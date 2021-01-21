using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                PrintResult(AddResult(a, b));
            }
            else if (command == "subtract")
            {
                PrintResult(SubstractResult(a, b));
            }
            else if (command == "multiply")
            {
                PrintResult(MultiplyResult(a, b));
            }
            else if (command == "divide")
            {
                PrintResult(DivideResult(a, b));
            }

        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }

        private static int DivideResult(int a, int b)
        {
            int result = a / b;
            return result;
        }

        private static int MultiplyResult(int a, int b)
        {
            int result = a * b;
            return result;
        }

        private static int SubstractResult(int a, int b)
        {
            int result = a - b;
            return result;
        }

        private static int AddResult(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
