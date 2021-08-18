using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int[] locksInput = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currGunBarelSize = gunBarrelSize;
            while (bullets.Any()&&locks.Any())
            {
                
                bulletsCount++;
                currGunBarelSize--;
                int currBullet = bullets.Pop();
                int currLock=locks.Peek();
                
                if (currBullet<=currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    
                }
                else
                {
                    Console.WriteLine("Ping!");
                   
                }
                if (currGunBarelSize == 0&&bullets.Any())
                {
                    currGunBarelSize = gunBarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }

            if (!locks.Any())
            {
                int moneyEarned = intelligenceValue - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }



        }
    }
}
