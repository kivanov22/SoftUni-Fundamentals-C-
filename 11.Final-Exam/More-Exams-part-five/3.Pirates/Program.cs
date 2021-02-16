using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cities = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] tokens = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);


                if (cities.ContainsKey(town))//if it exists
                {
                    cities[town]["population"] += population;
                    cities[town]["gold"] += gold;


                }
                else
                {
                    cities.Add(town, new Dictionary<string, int>()//if not exist we add new city with two key value pair
                    {
                        {"population",population},
                        {"gold",gold }
                    });
                }
                command = Console.ReadLine();
            }

             command = Console.ReadLine();

            while (command!="End")
            {
                string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string town = tokens[1];
                int people;
                int gold;

                switch (tokens[0])//we take command plunder or prosper
                {
                    case "Plunder":
                        people = int.Parse(tokens[2]);
                        gold = int.Parse(tokens[3]);

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        cities[town]["population"] -= people;
                        cities[town]["gold"] -= gold;

                        if (cities[town]["population"]<=0 || cities[town]["gold"]<=0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            cities.Remove(town);
                        }
                        break;
                    case "Prosper":

                        gold = int.Parse(tokens[2]);

                        if (gold<0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            cities[town]["gold"] += gold;
                            Console.WriteLine($"{gold } gold added to the city treasury. {town} now has {cities[town]["gold"]} gold.");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            if (cities.Count>0)
            {
                cities = cities.OrderByDescending(t => t.Value["gold"])
                    .ThenBy(t => t.Key).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var town in cities)
                {
                    int population = town.Value["population"];
                    int gold = town.Value["gold"];
                    Console.WriteLine($"{town.Key} -> Population: {population} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            

        }
    }
}
