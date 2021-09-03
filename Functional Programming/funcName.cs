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


using System;

namespace ConsoleApp129
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> func = name => $"Sir {name}";
            

           
            Console.WriteLine(FuncMethod("Ivan"));
            Console.WriteLine(func("Peter"));
        }

        static string FuncMethod(string name)
        {
            return $"Sir {name}";
        }
    }
}

