using System;

namespace ConsoleApp140
{
    class Program
    {
        static void Main(string[] args)
        {
            //fact(x)=fact(x-1)+fact(x-2)
            //functional languages-> Haskel
            Console.WriteLine("Въведи едно число.");

            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи второ число.");
            int secondNum = int.Parse(Console.ReadLine());
            long resultMult = Multiply(firstNum, secondNum);
            int resultSum = Sum(firstNum, secondNum);
            Console.WriteLine($"Първото число умножено по второто число: {resultMult}");
            Console.WriteLine($"Първото число + второто число {resultSum}");
            Console.WriteLine($"Първото число на квадрат -> { Math.Pow(firstNum, 2)}");
            Console.WriteLine($"Второто число на квадрат -> { Math.Pow(secondNum, 2)}");
            if (firstNum%2==0)
            {
                Console.WriteLine("Първото число е четно");
            }
            else
            {
                Console.WriteLine("Първото число е нечетно");

            }
            if (secondNum % 2 == 0)
            {
                Console.WriteLine("Второто число е четно");
            }
            else
            {
                Console.WriteLine("Второто число е нечетно");

            }

        }

        static long Multiply(int a, int b)
        {
            return a * b;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
////

using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(MyParse);
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }

        static int MyParse(string numberAsString)
        {
            int number = 0;
            foreach(var digit in numberAsString)
            {
                number *= 10;
                number += (digit-'0');
            }
            return number;
        }
    }
}


////

using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(
                new char[] { ' ', '.', '!', '?', ',', ':', ';' },
                StringSplitOptions.RemoveEmptyEntries);
            var upperLetterWords = words.Where(word => char.IsUpper(word[0]));
            foreach(var word in upperLetterWords)
            {
                Console.WriteLine(word);
            }    
        }
               
    }
}



