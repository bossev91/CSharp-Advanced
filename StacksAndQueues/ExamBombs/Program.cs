using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamBombs
{
    class Program
    {
        static void Main(string[] args)
        {
            // DaturaBombs = 40
            // CherryBombs = 60
            // SmokeDecoyBombs = 120

            //TODO - Counter about the bombs !

            int[] eff = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] cas = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            bool isComplete = false;

            Queue<int> effects = new Queue<int>(eff);
            Stack<int> casing = new Stack<int>(cas); //  тук ще намаляме стойноста с 5

            int cherryBombsCount = 0;  // 40
            int daturaBombsCount = 0;   // 60
            int smokeDecoyBombsCount = 0;  // 120

            while (true) 
            {
                if(effects.Count == 0 || casing.Count == 0)
                {
                    break;
                }

                int curEfect = effects.Peek();
                int curCasing = casing.Peek();

                if (curEfect + curCasing == 40)
                {
                    daturaBombsCount++;
                    effects.Dequeue();
                    casing.Pop();
                }
                else if (curEfect + curCasing == 60)
                {
                    cherryBombsCount++;
                    effects.Dequeue();
                    casing.Pop();
                }
                else if (curEfect + curCasing == 120)
                {
                    smokeDecoyBombsCount++;
                    effects.Dequeue();
                    casing.Pop();
                }
                else
                {
                    casing.Push(casing.Pop() - 5); 
                }

                if(daturaBombsCount >= 3 && cherryBombsCount >= 3 && smokeDecoyBombsCount >= 3)
                {
                    isComplete = true;
                    break;
                }
             
            }
            if(!isComplete)
            {
                Console.WriteLine("You don,t have enought materials to fill the bomb pouch.");
                Console.WriteLine("Bomb Effects: empty");
                Console.WriteLine("Bomb Cassing: empty");
            }
            else
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
                Console.WriteLine($"Bomb Cassing: {string.Join(", ", casing)}");
            }
            
            Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
            Console.WriteLine($"Datura Bombs: {daturaBombsCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");

        }
    }
}
