using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[5, 10];
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    table[row, col] = row * col;
                }
            }
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(table[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
