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

            string command = Console.ReadLine();
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            while (command != "end")
            {
                if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int, int> ariteticFunc = GetArithmeticFunc(command);
                    numbers = numbers.Select(ariteticFunc).ToList();
                }

                command = Console.ReadLine();
            }

            static Func<int, int> GetArithmeticFunc(string command)
            {
                Func<int, int> ariteticFunc = num => num;
                if (command == "add")
                {
                    ariteticFunc = num => num + 1;
                    //numbers= numbers.Select(n => ariteticFunc(n)).ToList();
                }
                else if (command == "multiply")
                {
                    ariteticFunc = num => num * 2;
                }
                else if (command == "subtract")
                {
                    ariteticFunc = num => num - 1;
                }

                return ariteticFunc;


            }

            static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
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
}
