using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ConsoleApp111
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();
            string input = Console.ReadLine();
            bool isValid = true;

            foreach (char item in input)
            {
                if (item=='('||item=='{'||item=='[')
                {
                    open.Push(item);
                }
                else
                {
                    if (open.Any())
                    {
                        bool isFirstValid = item == ')' && open.Pop() == '(';
                        bool isFirstValid2 = item == '}' && open.Pop() == '{';
                        bool isFirstValid3 = item == ']' && open.Pop() == '[';
                        if (isFirstValid||isFirstValid2||isFirstValid3)
                        {
                            continue;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }

                }

            }

            if (isValid)
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
