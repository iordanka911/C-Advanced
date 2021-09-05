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
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();
            numbers = numbers.Where(num => num % n != 0).ToList();

            Action<List<int>> print =
                nums => Console.WriteLine(string.Join(" ", nums));
            print(numbers);
        }
    }
}
