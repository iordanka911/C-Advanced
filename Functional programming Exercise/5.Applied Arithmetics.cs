using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace ConsoleApp131
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Func<int, int>> arithmeticFuncions =
                new Dictionary<string, Func<int, int>>()
                {
                    { "add", num => num + 1 },
                    { "multiply", num => num * 2 },
                    { "subtract", num => num - 1 }
                };
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            while (command != "end")
            {
                if (arithmeticFuncions.ContainsKey(command))
                {
                    Func<int, int> func = arithmeticFuncions[command];

                    numbers = numbers.Select(func).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }


                command = Console.ReadLine();
            }


        }
    }
}
