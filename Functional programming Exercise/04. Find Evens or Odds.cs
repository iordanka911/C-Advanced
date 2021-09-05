using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp131
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();
            int start = ranges[0];
            int end = ranges[1];

            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateRangeOfNums =
                (s, e) =>
                {
                    List<int> nums = new List<int>();

                    for (int i = s; i <=e; i++)
                    {
                       nums.Add(i); 
                    }

                    return nums;
                };
            List<int> numbers = generateRangeOfNums(start, end);

            Predicate<int> predicate = n => true;

            if (criteria=="odd")
            {
                predicate = n => n % 2 != 0;

            }
            else if (criteria=="even")
            {
                predicate = n => n % 2 == 0;
            }
            //numbers.Where(n => n % 2 == 0);
            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));

          //Console.WriteLine(string.Join(", ",MyWhere(numbers, n => n % 2 == 0)));
            //MyWhere(numbers, n => n % 2 == 0);
        }

        static List<int> MyWhere(List<int> numbers,Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (int currNumber in numbers)
            {
                if (predicate(currNumber))
                {
                    newNumbers.Add(currNumber);
                }
            }

            return newNumbers;
        }
    }
}
