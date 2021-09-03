using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp129
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ")
                .ToList();

            List<string> newNames = names.Select(name => $"Sir {name}").ToList();

            PrintNamesMethod(newNames);
        }

        static void PrintNamesMethod(List<string> names)
        {
            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
