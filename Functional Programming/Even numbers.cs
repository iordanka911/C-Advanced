using System;
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

             int[] evenNumbers= array.Where(x=>x%2==0).ToArray();

             Console.WriteLine(String.Join(" ",evenNumbers));
        }
    }
}
