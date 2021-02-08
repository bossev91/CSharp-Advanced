using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamFlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            int wreath = 0;
            int temp = 0;

            while (lilies.Count != 0 && roses.Count != 0)
            {
                int sum = lilies.Peek() + roses.Peek();

                if (sum == 15)
                {
                    wreath++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                    
                }
                else if (sum < 15)
                {
                    temp += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            while (temp >= 15)
            {
                temp -= 15;
                wreath++;
            }

            bool isComplete = wreath >= 5;
            if (isComplete)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else
            {
                int needed = 5 - wreath;
                Console.WriteLine($"You didn't make it, you need {needed} wreaths more!");
            }
        }
    }
}
