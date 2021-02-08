using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamLootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
                int totalSum = 0;
            bool isEpic = false;

            while(true)
            {
                if (firstBox.Count == 0 || secondBox.Count == 0)
                {
                    break;
                }

                int sum = firstBox.Peek() + secondBox.Peek();

                if(sum % 2 == 0) // even
                {
                    totalSum += sum;
                    {
                        if(totalSum >= 100)
                        {
                            isEpic = true;
                        }
                    }
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());                   // odd
                }

            }
            string grade = string.Empty;
            if(isEpic)
            {
                grade = "epic!";
            }
            else
            {
                grade = "poor...";

            }

            if(firstBox.Count == 0)
            {
                Console.WriteLine($"First lootbox is empty");
                Console.WriteLine($"Your loot was {grade} Value: {totalSum}");
            }
            else
            {
               
                    Console.WriteLine($"Second lootbox is empty");
                    Console.WriteLine($"Your loot was {grade} Value: {totalSum}");
                
            }
        }
    }
}
