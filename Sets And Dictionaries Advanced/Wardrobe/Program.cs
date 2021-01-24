using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> myWardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(",").ToArray();

                if(!myWardrobe.ContainsKey(color))
                {
                    myWardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if(!myWardrobe[color].ContainsKey(item))
                    {
                        myWardrobe[color].Add(item, 0);
                    }
                    myWardrobe[color][item]++;
                }
            }

            string[] searched = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in myWardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (searched[0] == item.Key && searched[1] == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                }
            }
        }
    }
}
