using System;

namespace ConsoleApp117
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[2,5]
            {
                {1,2,3,4,5},
                {1,2,3,4,5}
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i,j]+" ");
                }

                Console.WriteLine();
            }

            int element = numbers[1, 1];
            Console.WriteLine(element);

        }
    }
}
