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

            Action<List<string>> printNames =
                n => Console.WriteLine(string.Join(
                    Environment.NewLine,n
                ));

            printNames(newNames);
        }
    }
}
 
