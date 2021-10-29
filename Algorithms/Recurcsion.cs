using System;

namespace Algorithms_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
        }

        private static void Hello()
        {
            Console.WriteLine("Hi");
            Hello();
        }
    }
}
