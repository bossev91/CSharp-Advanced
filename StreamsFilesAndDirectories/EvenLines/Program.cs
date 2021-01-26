using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{

    static void Main(String[] args)
    {

        string pattern = @"[-,!.?]";

        using (StreamReader reader = new StreamReader("../../../text.txt"))
        {
            string line = reader.ReadLine();
            int counter = 0;

            while(line != null)
            {
                if(counter % 2 == 0)
                {
                    line = Regex.Replace(line, pattern, "@");
                    string[] newLine = line.Split();
                    Console.Write(string.Join(" ",newLine.Reverse()));
                    Console.WriteLine();
                    
                }
                line = reader.ReadLine();
                counter++;
            }
        }
        
    }
}