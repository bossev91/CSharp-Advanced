using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] reversed = songs.Reverse().ToArray();

          
            
            Queue<string> queue = new Queue<string>(songs);

          

            while (queue.Count != 0)
            {

                string input = Console.ReadLine();
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                
                   
              


                if (command == "Play")
                {
                    queue.Dequeue();   
                  

                }
                else if(command == "Add")
                {
                    string curSong = input.Substring(4);

                    if (!queue.Contains(curSong))
                    {
                        queue.Enqueue(curSong);
                    }
                    else
                    {
                        Console.WriteLine($"{curSong} is already contained!");
                    }
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
