using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            Queue<int> queue = new Queue<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }



        }
    }
}
