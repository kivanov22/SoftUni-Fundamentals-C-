using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> catalogue = new List<Catalogue>();
            string lines = Console.ReadLine();

            while (lines !="End")
            {
                string[] cmdArgs = lines.Split();
                string type = cmdArgs[0].ToLower();
                string model = cmdArgs[1];
                string color = cmdArgs[2].ToLower();
                int horsePower = int.Parse(cmdArgs[3]);

                Catalogue catalogues = new Catalogue(type,model,color,horsePower);

                catalogue.Add(catalogues);

                lines = Console.ReadLine();
            }
            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                string modelType = command;

                Catalogue printCar = catalogue.First(x => x.Model == modelType);//returns the first element in the collection 
                Console.WriteLine(printCar);
                command = Console.ReadLine();
            }
            List<Catalogue> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Catalogue> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHp = onlyCars.Sum(x => x.HorsePower);//total
            double totalTruckHp = onlyTrucks.Sum(x => x.HorsePower);

            double averageCarHp = 0.0;
            double averageTruckHp = 0.0;

            if (onlyCars.Count>0)
            {
                averageCarHp = totalCarsHp / onlyCars.Count;
            }
            if (onlyTrucks.Count>0)
            {
                averageTruckHp = totalTruckHp / onlyTrucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");
        }
    }
    class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();// string builder for storing data in strings and then display with append 

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");//if not = car it takes Truck ,else Car
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().Trim();//trim deleted space in the end
        }
    }
}
