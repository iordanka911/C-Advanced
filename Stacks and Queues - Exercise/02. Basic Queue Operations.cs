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
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(numbersInput[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            bool isFound = numbers.Contains(x);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count==0)
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
