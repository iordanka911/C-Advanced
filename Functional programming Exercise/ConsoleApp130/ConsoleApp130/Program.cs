using System;
using System.Threading.Channels;

namespace ConsoleApp130
{
    class Program
    {
        static void Main(string[] args)
        {

            Bear gogi = new Bear();
            gogi.Age = 28;
            gogi.DaysSinceEaten = 5;
            gogi.Name = "Gogi";


            Bear dimitrichkoBear = new Bear();
            dimitrichkoBear.Age = 28;
            dimitrichkoBear.DaysSinceEaten = 2;
            dimitrichkoBear.Name = "Dimitrichko";


            Bear puhBear = new Bear();
            puhBear.Age = 25;
            puhBear.DaysSinceEaten = 3;
            puhBear.Name = "PuhBear";


            Shirt calvinKlain = new Shirt();
            calvinKlain.Size = "XXXL";
            calvinKlain.Quantity = 55;
            calvinKlain.Price = 3;

            Bear[] bearZoo = new Bear[3] { gogi, dimitrichkoBear, puhBear };

            foreach (Bear bear in bearZoo)
            {
                if(bear.DaysSinceEaten>=3)
                     
                    bear.Eat();
            }
            //calvinKlain.Wash();

            Console.WriteLine($"Teniska calvin: Size -> {calvinKlain.Size}" +
                              $" Quantity -> {calvinKlain.Quantity} " +
                              $"Price -> {calvinKlain.Price}");
        }
    }
}
