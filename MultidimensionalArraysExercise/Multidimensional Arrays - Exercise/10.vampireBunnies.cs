using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ConsoleApp119
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            char[,] field = new char[n, m];
            int playerRow = -1;
            int playerCol = -1;
            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < m; col++)
            //    {
            //        if (field[row,col]=='P')
            //        {
            //            playerRow = row;
            //            playerCol = col;
            //        } 
            //    }
            //}

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (char direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;
                if (direction=='U')
                {
                    newPlayerRow--;
                }
                else if (direction=='D')
                {
                    newPlayerRow++;
                }
                else if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }

                if (!IsValidCell(newPlayerRow,newPlayerCol,n,m))
                {
                    isWon = true;
                    field[playerRow, playerCol] = '.';
                    //spread bunnies
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);

                }
                else if (field[newPlayerRow,newPlayerCol]=='.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    //spread bunnies
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                    //check if dead
                    if (field[playerRow,playerCol]=='B')
                    {
                        isDead = true;
                    }
                   

                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    //spread bunnies
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);

                }


                if (isDead||isWon)
                {
                    break;
                }

                
            }
            PrintField(field);
            string res = "";
            if (isWon)
            {
                res += "won";
            }
            else
            {
                res += "dead";
            }

            res += $": {playerRow} {playerCol}";
            Console.Write(res);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row,col]);
                }

                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] field)
        {
           
            foreach (int[] bunnyCoordinates in bunniesCoordinates)
            {
                int row = bunnyCoordinates[0];
                int col = bunnyCoordinates[1];

                SpreadBunny(row - 1, col, field);
                SpreadBunny(row + 1, col, field);
                SpreadBunny(row , col-1, field);
                SpreadBunny(row, col+1, field);


            }
        }

        private static void SpreadBunny(int row, int col, char[,] field)
        {
            int rowsLenght = field.GetLength(0);
            int colsLenght = field.GetLength(1);

            if (IsValidCell(row,col,rowsLenght,colsLenght))
            {
                field[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunniesCoordinates(char[,] field)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
               for (int col = 0; col < field.GetLength(1); col++)
                {
                  if (field[row, col] == 'B')
                    {
                       bunniesCoordinates.Add(new int[]{row,col});
                    }
                }
            }

            return bunniesCoordinates;
        }

        private static bool IsValidCell(int newPlayerRow, int newPlayerCol, int n, int m)
        {
            return newPlayerRow >= 0 && newPlayerRow < n && newPlayerCol >= 0 && newPlayerCol < m;
        }
    }
}
