using System;

namespace _02.ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int commandCount = int.Parse(Console.ReadLine());
            bool isWin = false;
            char[][] field = new char[rows][];
            var playerRow = 0;
            var playerCol = 0;
            for (int i = 0; i < rows; i++)
            {
                var chars = Console.ReadLine().ToCharArray();
                field[i] = chars;
            }

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                        break;
                    }
                }
            }

            while (commandCount > 0)
            {
                string command = Console.ReadLine();
                field[playerRow][playerCol] = '-';


                if (command == "up" && playerRow - 1 >= 0)
                {
                    playerRow--;

                }
                else if (playerRow - 1 < 0)
                {
                    playerRow = rows - 1;
                }
                if (command == "down" && playerRow + 1 < rows)
                {
                    playerRow++;
                }
                else if (playerRow + 1 > rows)
                {
                    playerRow = 0;
                }
                if (command == "left" && playerCol - 1 >= 0)
                {
                    playerCol--;
                }
                else if (playerCol - 1 < 0)
                {
                    playerCol = rows - 1;
                }
                if (command == "right" && playerCol + 1 < field[playerRow].Length)
                {
                    playerCol++;
                }
                else if (playerCol + 1 > field[playerRow].Length)
                {
                    playerCol = 0;
                }


                if (field[playerRow][playerCol] == 'B')
                {
                    if (command == "up" && playerRow - 1 >= 0)
                    {
                        playerRow--;

                    }
                    else if (playerRow - 1 < 0)
                    {
                        playerRow = rows - 1;
                    }
                    if (command == "down" && playerRow + 1 < rows)
                    {
                        playerRow++;
                    }
                    else if (playerRow + 1 > rows)
                    {
                        playerRow = 0;
                    }
                    if (command == "left" && playerCol - 1 >= 0)
                    {
                        playerCol--;
                    }
                    else if (playerCol - 1 < 0)
                    {
                        playerCol = rows - 1;
                    }
                    if (command == "right" && playerCol + 1 < field[playerRow].Length)
                    {
                        playerCol++;
                    }
                    else if (playerCol + 1 > field[playerRow].Length)
                    {
                        playerCol = 0;
                    }
                }
                if (field[playerRow][playerCol] == 'T')
                {
                    if (command == "up" && playerRow - 1 >= 0)
                    {
                        playerRow++;
                    }
                    else if (command == "down" && playerRow + 1 < rows)
                    {
                        playerRow--;
                    }
                    else if (command == "left" && playerCol - 1 >= 0)
                    {
                        playerCol++;
                    }
                    else if (command == "right" && playerCol + 1 < field[playerRow].Length)
                    {
                        playerCol--;
                    }
                }
                if (field[playerRow][playerCol] == 'F')
                {
                    isWin = true;
                    field[playerRow][playerCol] = 'f';
                    break;

                }
                field[playerRow][playerCol] = 'f';
                commandCount--;
            }

            if (isWin)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(field[i]));
            }
        }
    }
}
