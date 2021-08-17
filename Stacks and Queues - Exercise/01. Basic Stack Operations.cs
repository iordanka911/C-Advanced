using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ConsoleApp110
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

            int n = data[0];
            int s = data[1];
            int x = data[2];

            int[] numbersInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
              numbers.Push(numbersInput[i]);  
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            bool isFound = numbers.Contains(x);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
            
        }
    }
}
