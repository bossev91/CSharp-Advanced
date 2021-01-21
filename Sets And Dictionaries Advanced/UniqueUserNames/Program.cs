using System;
using System.Collections.Generic;

namespace SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if(!names.Contains(input))
                {
                    names.Add(input);
                }
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
