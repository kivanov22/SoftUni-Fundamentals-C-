using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.VehicleCatalogue
{
    class Program
    {
        class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }

        class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }
            public int HorsePower { get; set; }

        }

        class Catalog
        {
            public List<Car> Cars { get; set; }

            public List<Truck> Trucks { get; set; }

            public Catalog() // инициализация на Cars и Trucks листовете в конструктора
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");

                if (input[0] == "end")
                {
                    break;
                }

                string typeOfVehicle = input[0];
                string brand = input[1];
                string model = input[2];
                int horseOrWeight = int.Parse(input[3]);

                if (typeOfVehicle == "Cars")
                {
                    catalog.Cars.Add(new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horseOrWeight
                    });
                }
                else if (typeOfVehicle == "Trucks")
                {
                    catalog.Trucks.Add(new Truck()
                    {

                        Brand = brand,
                        Model = model,
                        Weight = horseOrWeight
                    });

                }
                if (catalog.Cars.Count > 0)
                {
                    Console.WriteLine($"Cars:");

                    foreach (Car cars in catalog.Cars.OrderBy(car => car.Brand))
                    {
                        Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                    }
                }
                if (catalog.Trucks.Count > 0)
                {
                    Console.WriteLine($"Trucks:");
                    foreach (Truck trucks in catalog.Trucks.OrderBy(truck => truck.Brand))
                    {
                        Console.WriteLine($"{trucks.Brand}: {trucks.Model} - {trucks.Weight}kg");
                    }
                }
            }
        }
    }
}
