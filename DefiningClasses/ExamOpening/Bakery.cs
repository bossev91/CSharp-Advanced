using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    class Bakery
    {
        public List<Employee> data;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Employee employee)
        {
            if(Capacity > data.Count)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee current = data.FirstOrDefault(e => e.Name == name);
            if(data.Contains(current))
            {
                data.Remove(current);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetOldestEmployee()
        {
            Employee oldest = data.OrderByDescending(e => e.Age).FirstOrDefault();
            return oldest;
        }

        public Employee GetEmployee(string name)
        {
            Employee current = data.FirstOrDefault(e => e.Name == name);
            return current;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var emoloyee in data)
            {
                sb.AppendLine($"{emoloyee}");
            }
            return sb.ToString().Trim();
        }
    }
}
