using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DictionariesAndSets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array[0]);

            Dictionary<string, int> studentsAges = new Dictionary<string, int>()
            {
                {"gogich",30},
                {"joji",80}
            };

            studentsAges.Add("Gogi", 38);
            studentsAges.Add("Doroteq",19);

            Console.WriteLine(studentsAges["Gogi"]);

            if (!studentsAges.ContainsKey("pepi"))
            {
                Console.WriteLine("Adding pepi");
                studentsAges.Add("pepi",13);
            }

            foreach (var student in studentsAges)
            {
                Console.WriteLine($"{student.Key} is {student.Value} old");
            }
        }
    }
}

