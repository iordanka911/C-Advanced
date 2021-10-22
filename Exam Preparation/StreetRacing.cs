using System;

namespace StreetRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Race race = new Race("RockPort Race", "Sprint", 1, 4, 150);
            Car car = new Car("BMW", "320ci", "NFS2005", 150, 1450);
            Console.WriteLine(car.ToString());
            race.Add(car);
            Console.WriteLine(race.Remove("NFS2005"));
            Car carOne = new Car("BMW", "320cd", "NFS2007", 150, 1350);
            Car carTwo = new Car("Audi", "A3", "NFS2004", 131, 1300);
            race.Add(carOne);
            race.Add(carTwo);
            Console.WriteLine(race.GetMostPowerfulCar());
            Console.WriteLine(race.Report());
        }
    }
}

///////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Participants = new List<Car>();
        }
        public List<Car> Participants { get; private set; } 
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public int Count => Participants.Count;

        public void Add(Car currentCar)
        {
            if (!this.Participants.Exists(car => car.LicensePlate == currentCar.LicensePlate) && this.Participants.Count < this.Capacity && currentCar.HorsePower <= this.MaxHorsePower)
            {
                this.Participants.Add(currentCar);
            }
        }

        public bool Remove(string licensePlate)
        {
            int removed = this.Participants.RemoveAll(car => car.LicensePlate == licensePlate);
            if (removed == 0)
            {
                return false;
            }

            return true;
        }

        public Car FindParticipant(string licensePlate)
        {
            return this.Participants.Find(car => car.LicensePlate == licensePlate);
        }

        public Car GetMostPowerfulCar()
        {
            int maxHorsePower = int.MinValue;

            for (int i = 0; i < this.Participants.Count; i++)
            {
                if (this.Participants[i].HorsePower > maxHorsePower)
                {
                    maxHorsePower = this.Participants[i].HorsePower;
                }
            }

            if (maxHorsePower != int.MinValue)
            {
                return this.Participants.Find(car => car.HorsePower == maxHorsePower);
            }

            return null;
        }

        public string Report()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var participant in Participants)
            {
                info.AppendLine(participant.ToString());
            }
            return info.ToString().TrimEnd();



        }
    }
}


////////
using System;
using System.Collections.Generic;
using System.Text;

namespace StreetRacing
{
   public  class Car
    {
        public Car(string make, string model, string licensePlate, int horsePower, double weight)
        {
            this.Make = make;
            this.Model = model;
            this.LicensePlate = licensePlate;
            this.HorsePower = horsePower;
            this.Weight = weight;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int HorsePower { get; set; }
        public double Weight { get; set; }


        public override string ToString()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nLicense Plate: {this.LicensePlate}\nHorse Power: {this.HorsePower}\nWeight: {this.Weight}";
        }
    }
}
