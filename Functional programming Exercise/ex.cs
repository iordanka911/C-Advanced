using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinkExamples
{
    class Program
    {
        static long Subtract(int a, int b)
        {
            return a - b;
        }
        //static void Main(string[] args)
        //{
        //    //long result = Multiply(2, 3);
        //    //Console.WriteLine(result);

        //    Func<int, int, long> func = Multiply;
        //    Func<int, int, long> func1 = Sum;
        //    Console.WriteLine(func(2,3));
        //    Console.WriteLine(func1(2, 3));

        //    Func<string> func3 = GetGreeting;
        //    Console.WriteLine(func3());
        //    PrintResult(1, 2, Subtract);
        //}


        static void Main(string[] args)
        {
               
                //Func<int, double, int, long, string, int, int, int[], Queue<int>, string>
                PrintResult(1, 2, Multiply);
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var newList=list.Where(EvenNumbers);
            var newList = list.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", newList));
        }
        static bool EvenNumbers(int x) => x % 2 == 0;
        //{
        //    //if (x%2==0)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //    return x % 2 == 0;
        //}
        static void PrintResult(int a, int b, Func<int, int, long> func)
        {
            for (int i = a; i < 5; i++)
            {
                var result = func(a + i, b + i);
                Console.WriteLine(new string('=', 50));
                Console.WriteLine($"Result: {result}");
                Console.WriteLine(new string('=', 50));
            }
           
        }
        static string GetGreeting()
        {
            return "Hello!";
        }
        static long Multiply(int a, int b)
        {
            return a * b;
        }
        static long Sum(int a, int b)
        {
            return a + b;
        }


    }
}
