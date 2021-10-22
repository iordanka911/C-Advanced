using System;

namespace SkiRental
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SkiRental skiRental = new SkiRental("New Alpine ski rental", 5);
            Ski firstSkiSet = new Ski("Rossignol", "XC70", 2017);
            Console.WriteLine(firstSkiSet);
            skiRental.Add(firstSkiSet);
            Console.WriteLine(skiRental.Remove("Rossignol", "XC90"));
            Console.WriteLine(skiRental.Remove("Rossignol", "XC70"));
            Ski secondSkiSet = new Ski("Fischer", "SpeedMax", 2018);
            Ski thirdSkiSet = new Ski("Salomon", "TopLine", 2020);

            skiRental.Add(secondSkiSet);
            skiRental.Add(thirdSkiSet);
            Ski newestSki = skiRental.GetNewestSki();
            Console.WriteLine(newestSki);
            Console.WriteLine(skiRental.Count);
            Console.WriteLine(skiRental.GetStatistics());
        }
    }
}

////////

using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        public Ski(string manufacturer, string model, int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
        }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{this.Manufacturer} - {this.Model} - {this.Year}";
        }
    }
}



////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> Skies;
        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Skies = new List<Ski>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.Skies.Count;

        public void Add(Ski ski)
        {
            if (this.Skies.Count < Capacity)
            {
                this.Skies.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            int removed = this.Skies.RemoveAll(x => x.Manufacturer == manufacturer && x.Model == model);
            return removed > 0 ? true : false;
        }

        public Ski GetNewestSki()
        {
            return this.Skies.OrderByDescending(x => x.Year).FirstOrDefault();
        }
        public Ski GetSki(string manufacturer, string model)
        {
            return this.Skies.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }
        public string GetStatistics()
        {
            return $"The skis stored in {this.Name}:{Environment.NewLine}{string.Join(Environment.NewLine, this.Skies)}";


        }
    }
}

