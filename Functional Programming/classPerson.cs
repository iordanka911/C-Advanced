using System;
using System.Collections.Generic;
using System.Linq;


namespace FunctionalProgramming
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person gogi = new Person();
            gogi.Name = "Dimitrichko";
            gogi.Age = 41;

            Console.WriteLine(gogi.Name);
        }
    }
}
