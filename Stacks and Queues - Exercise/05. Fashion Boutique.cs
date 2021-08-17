using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ConsoleApp110
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allClothesInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> allClothes = new Stack<int>(allClothesInput);

            int boxCapacity = int.Parse(Console.ReadLine());
            int cureentRackCapacity = boxCapacity;
            int racksCount = 1;
            while (allClothes.Any())
            {
                int clothes = allClothes.Pop();
                cureentRackCapacity -= clothes;

                if (cureentRackCapacity<0)
                {
                    racksCount++;
                    cureentRackCapacity = boxCapacity-clothes;
                    
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
