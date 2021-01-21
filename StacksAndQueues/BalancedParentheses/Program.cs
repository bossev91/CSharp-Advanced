using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> openParentheses = new Stack<char>();
            bool isEqual = true;

            foreach (char c in expression)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    openParentheses.Push(c);
                }
                else
                {
                    if(!openParentheses.Any())
                    {
                        isEqual = false;
                        break;

                    }
                    char currentOpenParentheses = openParentheses.Pop();
                    bool isRoundBalanced = currentOpenParentheses == '(' && c == ')';
                    bool isCurlyBalanced = currentOpenParentheses == '{' && c == '}';
                    bool isSquareBalanced = currentOpenParentheses == '[' && c == ']';

                    if(isRoundBalanced == false && isCurlyBalanced == false && isSquareBalanced == false)
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            if (isEqual)
            {
                Console.WriteLine("YES");
            }
            else

            {
                Console.WriteLine("NO");
            }
        }
    }
}
