using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsCounts.Add(word.ToLower(), 0);
            }

            string text = File.ReadAllText("../../../text.txt").ToLower();
            string[] newText = text.Split(new[] {',','.','?',' ','-','!' }).ToArray();

            foreach (var word in newText)
            {
                if(words.Contains(word))
                {
                    wordsCounts[word]++;
                }
            }

            {
                using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
                {
                    foreach (var wor in wordsCounts)
                    {
                        writer.WriteLine($"{wor.Key} - {wor.Value}");
                    }
                }

                using (StreamWriter writer = new StreamWriter("../../../expectedResult.txt"))
                {
                    foreach (var wor in wordsCounts.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{wor.Key} - {wor.Value}");
                    }
                }
                   
            }



        }
    }
}
