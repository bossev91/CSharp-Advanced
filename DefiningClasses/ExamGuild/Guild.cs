using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> roster;
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return roster.Count; } }


        public void AddPlayer(Player player)
        {
            if (Capacity > roster.Count)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player currentPlayer = roster.FirstOrDefault(p => p.Name == name);
            if (roster.Contains(currentPlayer))
            {
                roster.Remove(currentPlayer);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PromotePlayer(string name)
        {
            Player currentPlayer = roster.FirstOrDefault(p => p.Name == name);
            {
                if (currentPlayer.Rank != "Member")
                {
                    currentPlayer.Rank = "Member";
                }
            }
        }
        public void DemotePlayer(string name)
        {
            Player currentPlayer = roster.FirstOrDefault(p => p.Name == name);
            {
                if (currentPlayer.Rank != "Trial")
                {
                    currentPlayer.Rank = "Trial";
                }
            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> tempList = new List<Player>();
            foreach (var item in roster)
            {
                if(item.Class == @class)
                {
                    tempList.Add(item);
                }
            }
            Player[] kickedArray = tempList.ToArray();
            roster = roster.Where(p => p.Class != @class).ToList();
            return kickedArray;
        }
            
            

        public string Report()
        {
            StringBuilder reportSb = new StringBuilder();
            reportSb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                reportSb.AppendLine(player.ToString());              
            }
            return reportSb.ToString().TrimEnd();
        }
    }
}
