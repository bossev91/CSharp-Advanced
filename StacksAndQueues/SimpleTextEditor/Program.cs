using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = string.Empty;

            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            stack.Push("");

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string command = cmdArg[0];
                
                if(command == "1")
                {
                    string currentText = cmdArg[1];
                    text = stack.Peek() + currentText;
                    stack.Push(text);                  
                }
                else if (command == "2")
                {
                    int count = int.Parse(cmdArg[1]);
                    string previous = stack.Peek();
                    previous = previous.Remove(text.Length - count);
                    stack.Push(previous);
                    
                }
                else if (command == "3")
                {
                    string current = stack.Peek();
                    int index = int.Parse(cmdArg[1]);
                    Console.WriteLine(current[index - 1]);
                }
                else if (command == "4" && stack.Any())
                {
                    stack.Pop();
                    
                }
            }          
        }
    }
}
