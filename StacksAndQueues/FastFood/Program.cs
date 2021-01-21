using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCapacity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while(true)
            {
                int currentOrder = queue.Peek();
                if(currentOrder > totalCapacity)
                {
                    break;
                }
               
                    totalCapacity -= currentOrder;
                    queue.Dequeue();
                
                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }
            if(queue.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            

        }
    }
}
