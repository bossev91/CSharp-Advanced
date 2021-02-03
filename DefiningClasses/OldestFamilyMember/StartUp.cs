using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                
                string[] pData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = pData[0];
                int age = int.Parse(pData[1]);

                Person currPerson = new Person(name, age);

                family.AddMember(currPerson);
                
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
