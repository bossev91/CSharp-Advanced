using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if(!numbers.ContainsKey(current))
                {
                    numbers.Add(current, 0);
                }
                numbers[current]++;
               
               
            }
                foreach (var item in numbers.Where(x => x.Value % 2 == 0))
                {
                    Console.WriteLine(item.Key);
                }
        }
    }
}
