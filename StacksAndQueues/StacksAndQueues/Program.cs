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

             Stack<int> stack = new Stack<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                stack.Push(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if(stack.Contains(x))
            {
                Console.WriteLine("true");                
            }
            else if(stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }



        }
    }
}
