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
            Console.WriteLine("Age now or then?");
            string input = Console.ReadLine();

            Func<int, DateTime,string> agePrinter=null;
            if (input=="now")
            {
                agePrinter = GetAge;
            }
            else if (input=="then")
            {
                agePrinter = GetAgeIn10Years;
            }

            Func<int, DateTime, string> agePrinterLambda = (age, date) => $"{age} години {date}";
            Console.WriteLine(agePrinterLambda(23, DateTime.Now));
            Console.WriteLine(agePrinter(5,DateTime.Now));
        }

        static string GetAge(int age,DateTime date)
        {
            return $"Your age is: {age} at {date}";
        }

        static string GetAgeIn10Years(int age, DateTime date)
        {
            return $"Your age is: {age+10} at {date}";
        }
    }
}
