using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            int taskToKill = int.Parse(Console.ReadLine());
            int taskValue = 0;
            int threadsValue = 0;

            while (tasks.Count != 0 && threads.Count != 0)
            {
                taskValue = tasks.Peek();
                threadsValue = threads.Peek();

                if (threadsValue >= taskValue)
                {
                    if (taskValue == taskToKill)
                    {
                        break;
                    }
                    else
                    {
                        tasks.Pop();
                        threads.Dequeue();
                    }

                }
                else if (threadsValue < taskValue)
                {
                    if (taskValue == taskToKill)
                    {
                        break;
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
            }
            Console.WriteLine($"Thread with value {threadsValue} killed task {taskValue}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
