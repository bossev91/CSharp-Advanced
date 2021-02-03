using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        
       public Family()
        {
            members = new List<Person>();
        }

        public List<Person> members { get; set; }

       

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person current = members.OrderByDescending(p => p.Age).FirstOrDefault();

            return current;
        }

        public void PrintMembers()
        {
            foreach (var item in members.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }


    }
    
}
