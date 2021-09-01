using System;
using System.Collections.Generic;
using System.Linq;


namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(Decimal.Parse)
                .Select(number => number+(number * 0.2m))
                .ToArray();
         
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }

      
        
    }
}
