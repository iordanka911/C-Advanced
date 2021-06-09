using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();
            books.Push("Pinokio");
            books.Push("War and peace");
            books.Push("Alhimikyt");

            Console.WriteLine(books.Pop());
            Console.WriteLine(books.Pop());
        }
    }
}



using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> expression = new Stack<string>();
            for (int i = input.Length-1; i >=0; i--)
            {
                expression.Push(input[i]);
            }

            while (expression.Count>1)
            {
                int leftNunmber = int.Parse(expression.Pop());
                string sign = expression.Pop();
                int rightNumber = int.Parse(expression.Pop());

                if (sign=="+")
                {
                    expression.Push((leftNunmber+rightNumber).ToString());
                }
                else if (sign == "-")
                {
                    expression.Push((leftNunmber - rightNumber).ToString());
                }
            }
            Console.WriteLine(expression.Pop());
        }
    }
}
