using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            bool isOrcsWins = true;
            List<int> plates = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            List<int> orcRes = new List<int>();

            

            for (int i = 1; i <= waves; i++)
            {
                Stack<int> orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
                if (i % 3 == 0)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    plates.Add(extraPlate);
                }
                while (orcs.Any() && plates.Count > 0)
                {
                    
                    int attackOrc = orcs.Peek();
                    int defPlate = plates[0];
                    if(attackOrc > defPlate)
                    {
                        orcs.Push(orcs.Pop() - defPlate);
                        plates.RemoveAt(0);
                    }
                    else if(attackOrc < defPlate)
                    {
                        plates[0] -= orcs.Pop();
                    }
                    else
                    {
                        orcs.Pop();
                        plates.RemoveAt(0);
                    }
                    orcRes = orcs.ToList();
                }

            }

            if(plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcRes)}");
            }



            
        }
    }
}
