using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCount = 1;
            int curCounter = 0;

            Stack<int> rack = new Stack<int>(clothes);

            while(rack.Any())
            {

                int current = rack.Peek();

                if(curCounter + current <= rackCapacity)
                {
                    curCounter += current;
                    rack.Pop();
                }
                else
                {
                    rackCount++;
                    curCounter = 0;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
