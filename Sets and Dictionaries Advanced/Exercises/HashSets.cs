using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> studentsInAdvances = new HashSet<string>();

            string input = Console.ReadLine();
            
            while (input!="end")
            {
                Console.WriteLine("Enter student in c# advanced course");
                studentsInAdvances.Add(input);
                input = Console.ReadLine();
            }

            Console.WriteLine($"Count is: {studentsInAdvances.Count}");
            studentsInAdvances.Remove("gogi");
            foreach (var student in studentsInAdvances)
            {
                Console.WriteLine(student);
            }

            while (true)
            {
                Console.WriteLine("Check if student is in course");
                input = Console.ReadLine();

                Console.WriteLine($"{studentsInAdvances.Contains(input)}");
            }
        }
    }
}
