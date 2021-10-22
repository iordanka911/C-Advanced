using System;

namespace TheRace
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize the repository
            Race race = new Race("Indianapolis 500", 10);

            //Initialzie cars
            Car car1 = new Car("ferrari", 150);
            Car car2 = new Car("lambo", 170);

            //Initialize racer1
            Racer racer1 = new Racer("Stephen", 40, "Bulgaria", car1);

            //Print Racer
            Console.WriteLine(racer1); //Racer: Stephen, 40 (Bulgaria)

            //Add Racer
            race.Add(racer1);
            //Remove Racer
            race.Remove("Vin Benzin"); //false

            Racer racer2 = new Racer("Mark", 34, "UK", car2);

            //Add Racer
            race.Add(racer2);

            Racer oldestRacer = race.GetOldestRacer(); // Racer with name Stephen
            Racer racerStephen = race.GetRacer("Stephen"); // Racer with name Stephen
            Racer fastestRacer = race.GetFastestRacer(); // Racer with name Mark

            Console.WriteLine(oldestRacer); //Racer: Stephen, 40 (Bulgaria)
            Console.WriteLine(racerStephen); //Racer: Stephen, 40 (Bulgaria)
            Console.WriteLine(fastestRacer); // Racer: Mark, 34 (UK)
            Console.WriteLine(race.Count); //2

            Console.WriteLine(race.Report());
            //Racers working at Indianapolis 500:
            //Racer: Stephen, 40 (Bulgaria)
            //Racer: Mark, 34 (UK)

        }
    }
}


//////

namespace TheRace
{
    public class Car
    {
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Name { get; set; }
        public int Speed { get; set; }
    }
}

////

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racerToRemove = data.FirstOrDefault(r => r.Name == name);
            if (racerToRemove == null)
            {
                return false;
            }

            data.Remove(racerToRemove);
            return true;
        }

        public Racer GetOldestRacer()
            => data.OrderByDescending(r => r.Age).FirstOrDefault();

        public Racer GetRacer(string name)
            => data.FirstOrDefault(r => r.Name == name);

        public Racer GetFastestRacer()
            => data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}


/////

namespace TheRace
{
    public class Racer
    {
        public Racer(string name, int age, string country, Car car)
        {
            Name = name;
            Age = age;
            Country = country;
            Car = car;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Car Car { get; set; }

        public override string ToString()
            => $"Racer: {Name}, {Age} ({Country})";
    }
}
