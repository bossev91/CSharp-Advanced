using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            HashSet<int> firstHash = new HashSet<int>();
            HashSet<int> secondHash = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                firstHash.Add(nums);
            }
            for (int i = 0; i < input[1]; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                secondHash.Add(nums);
            }

            var newHash = firstHash.Intersect(secondHash).ToArray();

            Console.WriteLine(string.Join(" ", newHash));

        }
    }
}
