using System;
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
            int[] array = new int[] { 5, 2, 7, 9, 9 };
            //var input=Console.ReadLine().Split().Select(n=>int.Parse(n)).ToArray();
            //var input=Console.ReadLine().Split().Select(Parser).ToArray();
            array = array.OrderBy(n=>n).ToArray();
           // array =array.OrderBy(Sort).ToArray();

            Console.WriteLine(String.Join(" ",array));
        }

        static int Parser(string n)
        {
            return int.Parse(n);
        }
        //static int Sort(int n)
        //{
        //    return n;
        //}
    }
}


///////


using System;
using System.Linq;

namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100);
            var groups = numbers.GroupBy(x => x.ToString().Length);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key + " " + group.Count());
            }

        }
    }
}


////////

 var numbers = Enumerable.Range(1, 100);
            int num = numbers.Aggregate(0, (sum, x) => sum + x);
            Console.WriteLine(num);

/////////


            var numbers = Enumerable.Range(1, 10);
            string num = numbers.Aggregate("", (sum, x) => sum + x);
            Console.WriteLine(num);

.................
    
      var numbers = Enumerable.Range(1, 10);
            var num = numbers.FirstOrDefault(x => x > 100);
            Console.WriteLine(num);


......................
     var numbers = Enumerable.Range(1, 10);
            var num = numbers.SingleOrDefault(x => x > 9);
            Console.WriteLine(num);


.................................
      var numbers = Enumerable.Range(1, 10);
            var num = numbers.First(x => x > 9);
            Console.WriteLine(num);


..........................................
    
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

            var filterName = Console.ReadLine(); // younger/older/exact
            var ageToCompareWith = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = p => true;
            if (filterName == "younger")
            {
                filter = p => p.Age < ageToCompareWith;
            }
            else if (filterName == "older")
            {
                filter = p => p.Age >= ageToCompareWith;
            }
            else if (filterName == "exact")
            {
                filter = p => p.Age == ageToCompareWith;
            }

            var filteredPeople = people.Where(filter);

            var printName = Console.ReadLine();
            Func<Person, string> printFunc = p => p.Name + " " + p.Age;
            if (printName == "name age")
            {
                printFunc = p => p.Name + " - " + p.Age;
            }
            else if (printName == "name")
            {
                printFunc = p => p.Name;
            }
            else if (printName == "age")
            {
                printFunc = p => p.Age.ToString();
            }

            var personAsString = filteredPeople.Select(printFunc);
            foreach (var str in personAsString)
            {
                Console.WriteLine(str);
            }
        }




    
