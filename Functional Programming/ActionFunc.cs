using System;
using System.Collections.Generic;
using System.Linq;


namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = Print;
            printer("Opaaaa");
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
