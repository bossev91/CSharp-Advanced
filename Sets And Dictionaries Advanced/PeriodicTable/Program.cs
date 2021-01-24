using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> table = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                foreach (var item in input)
                {
                    table.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", table));
        }
    }
}
