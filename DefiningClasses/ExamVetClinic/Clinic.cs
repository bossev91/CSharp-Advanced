using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VetClinic
{
    class Clinic
    {
        public List<Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Pet pet)
        {
            if(Capacity > data.Count)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet petToRemove = data.FirstOrDefault(p => p.Name == name);
            if(data.Contains(petToRemove))
            {
                data.Remove(petToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pet GetPet(string name, string owner)
        {
            Pet currentPet = data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
            if (data.Contains(currentPet))
            {
                return currentPet;
            }
            else
            {
                return null;
            }
        }

        public Pet GetOldestPet()
        {
            Pet oldestPet = data.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString();
        }

    }
}
