using System;
using System.Linq;

namespace MultidimensionalArarys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int maxSum = 0;
            int maxSumCol = 0;
            int maxSumRow = 0;
            for (int row = 0; row < rows - n+1; row++)
            {
                for (int col = 0; col < cols - n+1; col++)
                {
                    int squareSum = 0;
                    for (int squareRow = row; squareRow < row+n; squareRow++)
                    {
                        for (int squareCol = col; squareCol < col+ n; squareCol++)
                        {
                            squareSum += matrix[squareRow, squareCol];
                        }
                    }
                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }



            for (int row = maxSumRow; row < maxSumRow + n; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
