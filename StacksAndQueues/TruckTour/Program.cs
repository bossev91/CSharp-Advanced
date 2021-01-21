using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }
   
            long index = 0;
            long lenght = pumps.Count();

            for (int i = 0; i < lenght; i++)
            {
                bool isCompleted = true;
                long totalAmount = 0;

                for (int j = 0; j < lenght; j++)
                {
                    string currentPump = pumps.Dequeue();
                    long[] currentPumpValues = currentPump.Split().Select(long.Parse).ToArray();
                    long currentAmount = currentPumpValues[0];
                    long distance = currentPumpValues[1];

                    totalAmount += currentAmount;

                    if(totalAmount >= distance)
                    {
                        totalAmount -= distance;
                    }
                    else
                    {
                        isCompleted = false;
                    }
                    pumps.Enqueue(currentPump);
                }

                if (isCompleted)
                {
                    index = i;
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(index);
        }
    }
}
