using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            char[,] mat = new char[n, n];
 
            int vRow = 0;
            int vCol = 0;
            int holes = 1;
            int rods = 0;
            
 
            for (int row = 0; row < mat.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
 
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    mat[row, col] = input[col];
 
                    if (mat[row,col]=='V')
                    {
                        vRow = row;
                        vCol = col;
                    }
                }
            }
 
 
           bool IsElectro = false;
           string command = Console.ReadLine();
 
 
           while (command!="End")
             {               
                              
                if (command == "up"&& IsInMatrix(mat, vRow-1, vCol))
                {
                    if (mat[vRow-1, vCol ] == '*')
                    {
                        mat[vRow, vCol] = '*';
                        vRow--;
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                    }
                    else if (mat[vRow-1, vCol] == 'C')
                    {
                        mat[vRow, vCol] = '*';
                        mat[vRow-1, vCol] = 'E';
                        holes++;
                        IsElectro = true;
                        break;
                    }
 
                    else if (mat[vRow-1,vCol]=='R')
                    {
                        rods++;                       
                        Console.WriteLine("Vanko hit a rod!");
                    }
                    else
                    {
                        mat[vRow, vCol] = '*';
                        holes++;
                        vRow--;    
                    }              
                }
 
                else if (command == "down" && IsInMatrix(mat, vRow + 1, vCol))
                    {
 
                    if (mat[vRow+1, vCol] == '*')
                    {
                        mat[vRow, vCol] = '*';
                        vRow++;
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                    }
                    else if (mat[vRow + 1, vCol] == 'C')
                    {
                        mat[vRow, vCol] = '*';
                        mat[vRow + 1, vCol] = 'E';
                        holes++;
                        IsElectro = true;
                        break;
                    }
 
                    else if (mat[vRow + 1, vCol] == 'R')
                    {
                         rods++;
                        Console.WriteLine("Vanko hit a rod!"); ;                       
                    }
 
                    else
                    {                        
                        mat[vRow, vCol] = '*';
                        holes++;
                        vRow++;
                    }               
 
                }
 
 
                else if (command == "left" && IsInMatrix(mat, vRow, vCol-1))
                  {
 
                    if (mat[vRow,vCol-1]=='*')
                    {
                        mat[vRow, vCol] = '*';
                        vCol--;
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                    }
                    else if (mat[vRow , vCol-1] == 'C')
                    {
                        mat[vRow, vCol] = '*';
                        mat[vRow, vCol-1] = 'E';
                        holes++;
                        IsElectro = true;
                        break;
                    }
 
                    else if (mat[vRow, vCol-1] == 'R')
                    {
                        rods++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                    else
                    {
                        mat[vRow, vCol] = '*';
                        holes++;
                        vCol--;                   
                    }              
                }
 
                else if (command == "right" && IsInMatrix(mat, vRow, vCol+1))
                    {
 
                    if (mat[vRow, vCol + 1] == '*')
                    {
                        mat[vRow, vCol] = '*';
                        vCol++;
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                    }
                    else if (mat[vRow , vCol+1] == 'C')
                    {
                        mat[vRow, vCol] = '*';
                        mat[vRow, vCol+1] = 'E';
                        holes++;
                        IsElectro = true;
                        break;
                    }
                    else if (mat[vRow, vCol + 1] == 'R')
                    {
                        rods++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                    else
                    {
                        mat[vRow, vCol] = '*';
                        holes++;
                        vCol++;
                    }
                }
 
 
                mat[vRow, vCol] = 'V';               
                command = Console.ReadLine();
            }
 
            if (IsElectro)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
            }
 
 
            //Print matrix
            for (int row = 0; row < mat.GetLength(0); row++)
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    Console.Write(mat[row,col]);
                }
                Console.WriteLine();
            }
 
 
        }
        private static bool IsInMatrix(char[,] matrix, int row, int col)  
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
