using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamCooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int bread = 0;  // 25
            int cake = 0; // 50
            int pastry = 0; // 75
            int fruitPie = 0; // 100

            while (liquids.Count != 0 && ingredients.Count != 0) 
            {
                int currentLiquid = liquids.Peek();
                int currentIngredient = ingredients.Peek();
                int sumOfThem = currentLiquid + currentIngredient;

                switch (sumOfThem)
                {
                    case 25:
                        PopAndDequeue(liquids, ingredients);
                        bread++;
                        break;
                    case 50:
                        PopAndDequeue(liquids, ingredients);
                        cake++;
                        break;
                    case 75:
                        PopAndDequeue(liquids, ingredients);
                        pastry++;
                        break;
                    case 100:
                        PopAndDequeue(liquids, ingredients);
                        fruitPie++;
                        break;
                    default:
                        liquids.Dequeue();
                        ingredients.Push(ingredients.Pop() + 3);
                        break;
                }
            }
            string liquidsLeft = "none";
            string ingredientsLeft = "none";

            if (liquids.Count != 0)
            {
                liquidsLeft = string.Join(", ", liquids);
            }
            if (ingredients.Count != 0)
            {
                ingredientsLeft = string.Join(", ", ingredients);
            }

            if (IsComplete(bread, cake, fruitPie, pastry))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
                Console.WriteLine($"Liquids left: {liquidsLeft}");
                Console.WriteLine($"Ingredients left: {ingredientsLeft}");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
                Console.WriteLine($"Liquids left: {liquidsLeft}");
                Console.WriteLine($"Ingredients left: {ingredientsLeft}");


            }
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");

        }

        private static void PopAndDequeue(Queue<int> liquids, Stack<int> ingredients)
        {
            liquids.Dequeue();
            ingredients.Pop();
        }
        public static bool IsComplete(int bread, int cake, int fruitPie, int pastry)
        {
            return bread >= 1 && cake >= 1 && fruitPie >= 1 && pastry >= 1;
        }
    }
}
