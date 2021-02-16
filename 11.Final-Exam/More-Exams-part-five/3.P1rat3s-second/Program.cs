using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.P1rat3s_second
{
    class Program
    {
        static void Main(string[] args)
        {
            var population = new Dictionary<string, int>();
            var gold = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] cmdArg = command.Split("||");
                string cityName = cmdArg[0];
                int people = int.Parse(cmdArg[1]);
                int treasure = int.Parse(cmdArg[2]);



                if (population.ContainsKey(cityName) || gold.ContainsKey(cityName))
                {
                    population[cityName] += people;
                    gold[cityName] += treasure;
                }
                else
                {
                    population[cityName] = people;
                    gold[cityName] = treasure;
                }

                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split("=>");
                string action = cmdArgs[0];
                string townName = cmdArgs[1];

                if (action == "Plunder")
                {
                    int people = int.Parse(cmdArgs[2]);
                    int treasure = int.Parse(cmdArgs[3]);

                    population[townName] -= people;
                    gold[townName] -= treasure;

                    Console.WriteLine($"{townName} plundered! {treasure} gold stolen, {people} citizens killed.");

                    if (population[townName] == 0 || gold[townName] == 0)
                    {
                        Console.WriteLine($"{townName} has been wiped off the map!");
                        population.Remove(townName);
                        gold.Remove(townName);
                    }
                }
                else if (action == "Prosper")
                {
                    int treasure = int.Parse(cmdArgs[2]);

                    if (treasure > 0)
                    {
                        gold[townName] += treasure;
                        Console.WriteLine($"{treasure} gold added to the city treasury. {townName} now has {gold[townName]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }

                }
                command = Console.ReadLine();
            }
            if (population.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {population.Count} wealthy settlements to go to:");

                foreach (var town in gold.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{town.Key} -> Population: {population[town.Key]} citizens, Gold: {gold[town.Key]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
