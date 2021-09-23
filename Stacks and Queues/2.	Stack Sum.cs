using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp134
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();

            Stack<int> numbers = new Stack<int>();
            string[] numbersAsList = numbersAsString.Split(' ');
            foreach (var number in numbersAsList)
            {
                numbers.Push(int.Parse(number));
            }

            while (true)
            {
                string line = Console.ReadLine();

                string[] lineParts = line.Split(' ');
                string command = lineParts[0].ToLower();
                if (command=="end")
                {
                    break;
                }
                else if (command=="add")
                {
                    numbers.Push(int.Parse(lineParts[1]));
                    numbers.Push(int.Parse(lineParts[2]));
                }
                else if (command=="remove")
                {
                    var numberOfElements = int.Parse(lineParts[1]);
                    if (numberOfElements<=numbers.Count)
                    {
                        for (int i = 0; i < numberOfElements; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            while (numbers.Count>0)
            {
                int number = numbers.Pop();
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
