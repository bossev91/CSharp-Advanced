using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(kids);
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            while(queue.Count != 1)
            {
               string curentKid = queue.Dequeue();
                
                {
                    if(count == n)
                    {
                        Console.WriteLine($"Removed {curentKid}");                        
                        count = 1;
                    }
                    else
                    {
                        queue.Enqueue(curentKid);
                        count++;
                    }
                }

            }
            Console.WriteLine($"Last is {string.Join(" ", queue)}");

        }
    }
}
