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
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Func<string, int, bool> func = (name, lenght) => name.Length <= n;
            names = names.Where(name => func(name, n)).ToList();
            //names = names.Where(name => name.Length <= n).ToList();

            //Action<List<string>> printFunc =
               // names => Console.WriteLine(string.Join(Environment.NewLine, names));

           // printFunc(names);
            Print(names);


        }

        static void Print(List<string> allNames)
        {
            Console.WriteLine(string.Join(Environment.NewLine,allNames));
        }

       
    }
}
