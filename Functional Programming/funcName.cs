using System;

namespace ConsoleApp129
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> func = name => $"Sir {name}";

            string res = func("Peter");
            Console.WriteLine(res);
        }
    }
}
