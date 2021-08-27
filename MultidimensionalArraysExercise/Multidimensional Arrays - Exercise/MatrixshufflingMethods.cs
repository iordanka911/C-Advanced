using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];

            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            //string command = Console.ReadLine();

            //while (command!="END")
            //{
            //    string[] commandData = Console.ReadLine().Split(" ");

            //    if (commandData.Length!=5||commandData[0]!="swap")
            //    {
            //        Console.WriteLine("Invalid input!");
            //        command = Console.ReadLine();
            //        continue;
            //        ;
            //    }

            //    command = Console.ReadLine();
            //}

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="END")
                {
                    break;
                }

                string[] commandData = command.Split(" ");
                if (commandData.Length!=5||commandData[0]!="swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int rowOne = int.Parse(commandData[1]);
                int colOne = int.Parse(commandData[2]);
                int rowTwo = int.Parse(commandData[3]);
                int colTwo = int.Parse(commandData[4]);

                bool isValidOne = IsValidCell(rowOne, rowTwo, n,m);
                bool isValidTwo = IsValidCell1(rowTwo, colTwo, n, m);
                //bool isOutOfMatrix = rowOne < 0 || rowOne >= n || colOne < 0 || colOne >= m;
                if (!isValidOne||!isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                PrintMatrix(matrix);
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsValidCell1(int rowTwo, int colTwo, int n, int m)
        {
            return rowTwo >= 0 && rowTwo < n &&
                   colTwo >= 0 && colTwo < m; ;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
           return row >= 0 && row < n &&
                  col >= 0 && col < m;
        }
    }
}
