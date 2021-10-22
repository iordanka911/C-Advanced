using System;
using System.Linq;
using System.Collections.Generic;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var input = Console.ReadLine();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }
            int totalMoney = 0;
            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "up")
                {
                    matrix[row, col] = '-';
                    row--;
                    if (row >= 0)
                    {
                        ClientMove(n, matrix, ref row, ref col, ref totalMoney);
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {totalMoney}");
                        break;
                    }
                }
                else if (comand == "down")
                {
                    matrix[row, col] = '-';
                    row++;
                    if (row < n)
                    {
                        ClientMove(n, matrix, ref row, ref col, ref totalMoney);
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {totalMoney}");
                        break;
                    }
                }
                else if (comand == "right")
                {
                    matrix[row, col] = '-';
                    col++;
                    if (col < n)
                    {
                        ClientMove(n, matrix, ref row, ref col, ref totalMoney);
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {totalMoney}");
                        break;
                    }
                }
                else if (comand == "left")
                {
                    matrix[row, col] = '-';
                    col--;
                    if (col >= 0)
                    {
                        ClientMove(n, matrix, ref row, ref col, ref totalMoney);
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {totalMoney}");
                        break;
                    }
                }
                if (totalMoney >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    Console.WriteLine($"Money: {totalMoney}");
                    matrix[row, col] = 'S';
                    break;
                }
            }

            PrintMatrix(n, matrix);
        }

        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void ClientMove(int n, char[,] matrix, ref int row, ref int col, ref int totalMoney)
        {

            if (char.IsDigit(matrix[row, col]))
            {
                totalMoney += matrix[row, col] - '0';
                matrix[row, col] = '-';
            }
            else if (matrix[row, col] == 'O')
            {
                matrix[row, col] = '-';
                for (int rows = 0; rows < n; rows++)
                {
                    for (int cols = 0; cols < n; cols++)
                    {

                        if (matrix[rows, cols] == 'O')
                        {
                            matrix[rows, cols] = '-';
                            row = rows;
                            col = cols;
                            matrix[row, col] = 'S';
                        }
                    }
                }
            }
        }
    }
}
