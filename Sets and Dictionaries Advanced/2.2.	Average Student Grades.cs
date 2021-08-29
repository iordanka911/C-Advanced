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

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsGrades = new 
                Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine().Split();
                var name = student[0];
                var grade = decimal.Parse(student[1]);
                if (!studentsGrades.ContainsKey(name))
                {
                   studentsGrades.Add(name,new List<decimal>()); 
                }

                studentsGrades[name].Add(grade);

            }

            foreach (var student in studentsGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average()})");
            }
        }
    }
}
