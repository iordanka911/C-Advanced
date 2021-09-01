using System;


namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadStudents();
        }

        static void ReadStudents(Func<string,int,string> printer)
        {
            int age = 0;
            do
            {
                Console.WriteLine("Student name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Student age: ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine(printer(name, age));

            } while (age != -1);

        }

        static string PrintStudentDvoikadjiq(string name, int age)
        {
            return $"2";
        }
        static string PrintStudentBulgarian(string name, int age)
        {
            return $"Bulgarian student is {age} and named {name}";
        }
        static string PrintStudentSoftUni(string name, int age)
        {
            return $"Softuni student is {age} and named {name}";
        }
    }
}
