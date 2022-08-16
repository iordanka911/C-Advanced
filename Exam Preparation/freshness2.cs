using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp160
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ingredients = Console.ReadLine().Split(' ').
            //Select(int.Parse).ToArray();

            var ingredients = new Queue<int>(Console.ReadLine().Split(' ').
                Select(int.Parse));

            var freshness = new Stack<int>(Console.ReadLine().Split(' ').
                Select(int.Parse));
            int dippingSauces = 0, greenSalads = 0, chocolateCakes = 0, lobsters = 0;

            while(ingredients.Count>0&&freshness.Count>0)
            {
                var ingredient= ingredients.Peek();
                var fresh = freshness.Peek();
                var freshnessLevel = ingredient * fresh;
                if (freshnessLevel == 150)
                {
                    dippingSauces++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (freshnessLevel == 250)
                {
                    greenSalads++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (freshnessLevel == 300)
                {
                    chocolateCakes++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if(freshnessLevel==400)
                {
                    lobsters++;
                    ingredients.Dequeue();
                    freshness.Pop();

                }
                else if (ingredient == 0)
                {
                    ingredients.Dequeue();
                }
                else
                {
                    freshness.Pop();
                    ingredient += 5;
                    ingredients.Dequeue();
                    ingredients.Enqueue(ingredient);
                }
            }

            if (dippingSauces > 0 && greenSalads > 0 && chocolateCakes > 0 && lobsters > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($" # Chocolate cake --> {chocolateCakes}");
                Console.WriteLine($" # Dipping sauce --> {dippingSauces}");
                Console.WriteLine($" # Green salad --> {greenSalads}");
                Console.WriteLine($" # Lobster --> {lobsters}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if(ingredients.Sum()>0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                if (chocolateCakes > 0)
                {
                    Console.WriteLine($" # Chocolate cake --> {chocolateCakes}");
                }
                if (dippingSauces > 0)
                {
                    Console.WriteLine($" # Dipping sauce --> {dippingSauces}");
                }
                if (lobsters > 0)
                {
                    Console.WriteLine($" # Lobster --> {lobsters}");
                }
                if (greenSalads > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalads}");
                }
               
            }
        }
    }
}
