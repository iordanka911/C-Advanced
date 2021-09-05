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

           
        }
    }
}




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
            Func<int, int> ariteticFunc = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            while (command!="end")
            {
                if (command=="add")
                {
                    ariteticFunc = num => num + 1;
                   numbers = numbers.Select(ariteticFunc).ToList();

                }
                else if(command=="multiply")
                {
                    ariteticFunc = num => num * 2;
                    numbers = numbers.Select(ariteticFunc).ToList();
                }
                else if (command == "subtract")
                {
                    ariteticFunc = num => num - 1;
                    numbers = numbers.Select(ariteticFunc).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                    numbers = numbers.Select(ariteticFunc).ToList();

                }
                
                command = Console.ReadLine();
            }


           
        }
    }
}

