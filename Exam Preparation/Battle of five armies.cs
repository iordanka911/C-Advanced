using System;

namespace _02._The_Battle_of_The_Five_Armies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armour = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] middleWorld = new char[rows][];
            var currentRow = 0;
            var currentCol = 0;

            for (int row = 0; row < middleWorld.GetLength(0); row++)
            {
                string middleWorldRow = Console.ReadLine();
                middleWorld[row] = new char[middleWorldRow.Length];
                for (int col = 0; col < middleWorldRow.Length; col++)
                {
                    middleWorld[row][col] = middleWorldRow[col];
                    if (middleWorld[row][col] == 'A')
                    {
                        currentCol = col;
                        currentRow = row;
                    }
                }
            }
            bool missionAccomplished = false;
            while (true)
            {
                var moves = Console.ReadLine().Split();
                string direction = moves[0];
                var spawnRow = int.Parse(moves[1]);
                var spawnCol = int.Parse(moves[2]);

                middleWorld[spawnRow][spawnCol] = 'O';
                armour--;
                switch (direction)
                {
                    case "up":
                        if (currentRow - 1 < 0)
                        {
                            continue;
                        }
                        middleWorld[currentRow][currentCol] = '-';
                        currentRow--;
                        break;
                    case "down":
                        if (currentRow + 1 == rows)
                        {
                            continue;
                        }
                        middleWorld[currentRow][currentCol] = '-';
                        currentRow++;
                        break;
                    case "left":
                        if (currentCol - 1 < 0)
                        {
                            continue;
                        }
                        middleWorld[currentRow][currentCol] = '-';
                        currentCol--;
                        break;
                    case "right":
                        if (currentCol + 1 == middleWorld[currentRow].Length)
                        {
                            continue;
                        }
                        middleWorld[currentRow][currentCol] = '-';
                        currentCol++;
                        break;
                }

                if (armour <= 0)
                {
                    middleWorld[currentRow][currentCol] = 'X';
                    break;
                }
                if (middleWorld[currentRow][currentCol] == 'O')
                {
                    armour -= 2;
                    if (armour <= 0)
                    {
                        middleWorld[currentRow][currentCol] = 'X';
                        break;
                    }
                    middleWorld[currentRow][currentCol] = '-';
                }
                else if (middleWorld[currentRow][currentCol] == 'M')
                {
                    missionAccomplished = true;
                    middleWorld[currentRow][currentCol] = '-';
                    break;
                }
                middleWorld[currentRow][currentCol] = 'A';
            }

            if (missionAccomplished)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
            }
            else
            {
                Console.WriteLine($"The army was defeated at {currentRow};{currentCol}.");
            }
            foreach (var row in middleWorld)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}

