using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] hatInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] scraftInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> data = new List<int>();
            int biggestSum = 0;
            
            Stack<int> hats = new Stack<int>(hatInput);
            Queue<int> scarf = new Queue<int>(scraftInput);

            while(hats.Any() && scarf.Any())
            {
                int currentHat = hats.Peek();
                int currentScarf = scarf.Peek();

                if(currentHat > currentScarf)
                {
                    int curSet = currentHat + currentScarf;
                    data.Add(curSet);
                    hats.Pop();
                    scarf.Dequeue();
                    if(curSet > biggestSum)
                    {
                        biggestSum = curSet;
                    }
                }
                else if(currentHat < currentScarf)
                {
                    hats.Pop();
                    
                }
                else if(currentHat == currentScarf)
                {
                    scarf.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }

            }

            
            //int biggest = data.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine($"The most expensive set is: {biggestSum}");
            Console.WriteLine(string.Join(" ", data));

        }
    }
}
