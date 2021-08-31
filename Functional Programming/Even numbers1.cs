using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Channels;
using System.Xml;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] evenNumbers = array
                // .Where(x => x % 2 == 0)
                .Where((x, index) =>
                {
                    Console.WriteLine($"Checking at array[{index}] {x} % 2 == 0 -> {x % 2 == 0}");
                    return x % 2 == 0;
                })
                //.Where(IsEven);
                .ToArray();


            List<int> evenNumbersCustom = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                //if (array[i] % 2 == 0)
                //{
                //    evenNumbersCustom.Add(array[i]);
                //}
                if (IsEven(array[i]))
                {
                    evenNumbersCustom.Add(array[i]);
                }
            }
            Console.WriteLine(String.Join(" ", evenNumbersCustom));
            Console.WriteLine(String.Join(" ", evenNumbers));
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
