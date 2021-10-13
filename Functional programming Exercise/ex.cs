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



///////

using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    class Person
    {
        public string Name;

        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                var parts = line.Split(", ");
                var person = new Person();
                person.Name = parts[0];
                person.Age = int.Parse(parts[1]);
                people.Add(person);
            }
            var filterName = Console.ReadLine();
            var ageToCompareWith = int.Parse(Console.ReadLine());

            Func<Person, bool> filter=p=>true;

            if (filterName=="younger")
            {
                filter = p => p.Age < ageToCompareWith;

            }
            else if (filterName=="older")
            {
                filter = p => p.Age >= ageToCompareWith;
            }
            else if (filterName=="exaxt")
            {
                filter = p => p.Age == ageToCompareWith;
            }

            var filteredPeople = people.Where(predicate: filter);

            var printName = Console.ReadLine();
            Func<Person, string> printFunc = p => p.Name + " " + p.Age;
            if (printName=="name age")
            {
                printFunc = p => p.Name + " - " + p.Age;
            }
            else if (printName=="name")
            {
                printFunc = p => p.Name;
            }
            else if (printName=="age")
            {
                printFunc = p => p.Age.ToString();
            }
            var personAsString = filteredPeople.Select(printFunc);
            foreach(var str in personAsString)
            {
                Console.WriteLine(str);
            }
        }
               
    }
}
