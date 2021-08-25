using System;
using System.Linq;

namespace MultidimensionalArarys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
           
            int[][] jaggedArray = new int[n][];
          

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                string[] input = Console.ReadLine().Split();
                jaggedArray[row] = new int[input.Length];
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = int.Parse(input[col]);
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
