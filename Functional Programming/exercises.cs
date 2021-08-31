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
            int[] array = new int[] { 5, 2, 7, 9, 9 };
            //var input=Console.ReadLine().Split().Select(n=>int.Parse(n)).ToArray();
            //var input=Console.ReadLine().Split().Select(Parser).ToArray();
            array = array.OrderBy(n=>n).ToArray();
           // array =array.OrderBy(Sort).ToArray();

            Console.WriteLine(String.Join(" ",array));
        }

        static int Parser(string n)
        {
            return int.Parse(n);
        }
        //static int Sort(int n)
        //{
        //    return n;
        //}
    }
}
