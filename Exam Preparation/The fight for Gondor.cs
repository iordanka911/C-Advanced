using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Exam_5_01_The_Fight_For_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesOfOrcs = int.Parse(Console.ReadLine());
            int[] platesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> plates = new Queue<int>(platesInput);
            Stack<int> orcs = new Stack<int>();
 
            int counter = 0;
            bool noPlates = false;
 
            while (counter < wavesOfOrcs)
            {
                counter++;
                int[] orcsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
 
                orcs = new Stack<int>(orcsInput);
 
                if (counter != 0 && counter % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(newPlate);
                }
 
                while (orcs.Count > 0 && plates.Count > 0)
                {
                    if (plates.Count == 0)
                    {
                        Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                        Console.Write($"Orcs left: {String.Join(", ", orcs)}");
                        noPlates = true;
                        break;
                    }
                    int currentPlate = plates.Peek();
                    int currentOrc = orcs.Peek();
 
                    if (currentOrc == currentPlate)
                    {
                        plates.Dequeue();
                        orcs.Pop();
                        if (plates.Count == 0)
                        {
                            Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                            Console.Write($"Orcs left: {String.Join(", ", orcs)}");
                            noPlates = true;
                            break;
                        }
                    }
                    else if (currentOrc > currentPlate)
                    {
                        currentOrc -= currentPlate;
                        orcs.Pop();
                        orcs.Push(currentOrc);
                        plates.Dequeue();
                        if (plates.Count == 0)
                        {
                            Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                            Console.Write($"Orcs left: {String.Join(", ", orcs)}");
                            noPlates = true;
                            break;
                        }
                    }
                    else
                    {
                        orcs.Pop();
                        currentPlate -= currentOrc;
                        plates.Dequeue();
                        plates.Enqueue(currentPlate);
 
                        for (int i = 0; i < plates.Count - 1; i++)
                        {
                            int currentValue = plates.Dequeue();
                            plates.Enqueue(currentValue);
                        }
                    }
                }
                if (noPlates == true)
                {
                    break;
                }
            }
            if (noPlates == false)
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.Write($"Plates left: {String.Join(", ", plates)}");
            }
 
        }
    }
}
