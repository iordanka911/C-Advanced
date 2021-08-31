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
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse)
                .Where(x=>x%2==0)
                .OrderBy(x=>x)
                .ToArray();

            Console.WriteLine(String.Join(", ",array));

          
        }
    }
}
