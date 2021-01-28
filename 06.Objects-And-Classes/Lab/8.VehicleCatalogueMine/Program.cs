using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.VehicleCatalogueMine
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogues = new Catalogue();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split("/");
                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                //int horsePower =int.Parse(cmdArgs[3]);
                //int weight = int.Parse(cmdArgs[3]);
                
              
                
                if (type == "Car")
                {
                    int horsePower = int.Parse(cmdArgs[3]);
                    Car cars = new Car(brand, model, horsePower);
                    catalogues.Cars.Add(cars);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(cmdArgs[3]);
                    Truck trucks = new Truck(brand, model, weight);
                    catalogues.Trucks.Add(trucks);
                }


                //Car cars = new Car(brand,model,horsePower);
                //catalogues.Cars.Add(cars);


                command = Console.ReadLine();
            }
            if (catalogues.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car cars in catalogues.Cars.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                }
            }
            if(catalogues.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck trucks in catalogues.Trucks.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{trucks.Brand}: {trucks.Model} - {trucks.Weight}kg");
                }
            }

        }

        class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        class Car
        {
            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        class Catalogue
        {
            public List<Car> Cars { get; set; }

            public List<Truck> Trucks { get; set; }

            public Catalogue() // инициализация на Cars и Trucks листовете в конструктора
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
    }
}
