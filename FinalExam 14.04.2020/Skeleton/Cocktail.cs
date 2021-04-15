using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> data;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            data = new List<Ingredient>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => data.Sum(x => x.Alcohol);


        public void Add(Ingredient ingredient)
        {
            if(!data.Contains(ingredient) && Capacity > data.Count)
            {
                data.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            var current = data.FirstOrDefault(x => x.Name == name);
            if(current != null)
            {
                data.Remove(current);
                return true;
            }

            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            var current = data.FirstOrDefault(x => x.Name == name);
            return current;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            var current = data.OrderByDescending(x => x.Alcohol).FirstOrDefault();
            return current;
        }

       
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }



    }
}
