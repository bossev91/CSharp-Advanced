using System;
using System.IO;
using System.Linq;using System.Text.RegularExpressions;



namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineRow = 1;
            
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
               
                char[] masive = {',','!','.','?','-','\''};

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (line != null)
                    {
                        int letterCounter = 0;
                        int punctoacion = 0;
                        for (int i = 0; i < line.Length; i++)
                        {
                            char currentChar = line[i];
                            if(char.IsLetter(currentChar))
                            {
                                letterCounter++;
                            }
                            if(masive.Contains(currentChar))
                            {
                                punctoacion++;
                            }

                        }
                        writer.WriteLine($"Line {lineRow++}: {line}({letterCounter})({punctoacion})");
                        
                        line = reader.ReadLine();
                    }
                }
                
            }
        }
    }
}
