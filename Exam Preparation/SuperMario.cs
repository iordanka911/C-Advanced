using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            var lives = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            char[][] maze = new char[rows][];
            var currRow = 0;
            var curCol = 0;

            for (int row = 0; row < maze.GetLength(0); row++)
            {
                var mazeRow = Console.ReadLine();
                maze[row] = new char[mazeRow.Length];
                for (int col = 0; col < mazeRow.Length; col++)
                {
                    maze[row][col] = mazeRow[col];
                    if (maze[row][col]=='M')
                    {
                        currRow = row;
                        curCol = col;
                    }
                }
            }
            bool missionAcpmplished = false;

            while (true)
            {
                var moves = Console.ReadLine().Split();
                var direction = char.Parse(moves[0]);
                var spawnRow = int.Parse(moves[1]);
                var spawnCol = int.Parse(moves[2]);

                maze[spawnRow][spawnCol] = 'B';
                lives--;
                switch (direction)
                {
                    case 'W':
                        if (currRow - 1 < 0)
                        {
                            continue;
                        }

                        maze[currRow][curCol] = '-';
                        currRow--;
                        break;

                    case 'S':
                        if (currRow + 1 == rows)
                        {
                            continue;
                        }

                        maze[currRow][curCol] = '-';
                        currRow++;
                        break;

                    case 'A':
                        if (curCol - 1 < 0)
                        {
                            continue;
                        }

                        maze[currRow][curCol] = '-';
                        curCol--;
                        break;

                    case 'D':
                        if (curCol + 1 == maze[currRow].Length)
                        {
                            continue;
                        }

                        maze[currRow][curCol] = '-';
                        curCol++;
                        break;

                }
                if (lives <= 0)
                {
                    maze[currRow][curCol] = 'X';
                    break;
                }
                if (maze[currRow][curCol] == 'B')
                {
                    lives -= 2;
                    if (lives <= 0)
                    {
                        maze[currRow][curCol] = 'X';
                        break;
                    }

                }
                else if (maze[currRow][curCol] == 'P')
                {
                    missionAcpmplished = true;
                    maze[currRow][curCol] = '-';
                    break;
                }

                maze[currRow][curCol] = 'M';
            }

                //Mario saves the princess or dies
                if (missionAcpmplished)
                {
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                }
                else
                {
                    Console.WriteLine($"Mario died at {currRow};{curCol}.");
                }

                foreach (char[] row in maze)
                {
                    Console.WriteLine(string.Join("", row));
                }
            
        }
    }
}
