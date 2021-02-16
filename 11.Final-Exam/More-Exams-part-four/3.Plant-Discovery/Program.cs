using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            var rarity = new Dictionary<string, int>();
            var rating = new Dictionary<string, List<double>>();

            var average = new List<double>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plants = Console.ReadLine().Split("<->");
                string plantName = plants[0];
                int rareRate = int.Parse(plants[1]);

                //rarity[plantName] = rareRate;

                if (rarity.ContainsKey(plantName))
                {
                    rarity[plantName] = rareRate;
                }
                else
                {
                    rarity.Add(plantName, rareRate);
                    rating.Add(plantName, new List<double>());
                }

            }
            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] cmdArgs = command.Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string plantName = cmdArgs[1];

                if (action == "Rate:")
                {
                    double givenRating = double.Parse(cmdArgs[2]);

                    //rating[plantName] += givenRating;
                    //ratingInput = givenRating;

                    if (rating.ContainsKey(plantName))
                    {
                        rating[plantName].Add(givenRating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (action == "Update:")
                {
                    int newRarity = int.Parse(cmdArgs[2]);

                    if (rarity.ContainsKey(plantName))
                    {
                        rarity[plantName] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (action == "Reset:")
                {
                    if (rating.ContainsKey(plantName))
                    {
                        rating[plantName].RemoveRange(0, rating[plantName].Count);//remove every value for this plant
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }


                command = Console.ReadLine();
            }

            Dictionary<string, double> averageRating = new Dictionary<string, double>();

            foreach (var item in rating)
            {
                if (item.Value.Count > 0)//go through the values for this plant
                {
                    averageRating.Add(item.Key, item.Value.Average());
                }
                else
                {
                    averageRating.Add(item.Key, 0);
                }
            }

            averageRating = averageRating.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);//sort and make it a dictionary

            Dictionary<string, List<double>> plantRarityRating = new Dictionary<string, List<double>>();

            foreach (var item in rarity.OrderByDescending(x => x.Value))
            {
                foreach (var ratings in averageRating.OrderByDescending(x => x.Value))
                {
                    if (item.Key == ratings.Key)//if item woochila == woochila key from ratings we add rarity
                    {
                        plantRarityRating.Add(item.Key, new List<double>());//add to rarity dictionary
                        plantRarityRating[item.Key].Add(item.Value);//rarity plant key we add to it some value
                        plantRarityRating[item.Key].Add(ratings.Value);//rarity plant adding rating value to rarity dictionary
                        // we merge rating with rarity
                    }
                }

            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var raritys in plantRarityRating.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {raritys.Key}; Rarity: {raritys.Value[0]}; Rating: {raritys.Value[1]:f2}");
                //                      key                         value on index 0        value to index 1
                //                                                         rarity              rating
            }


        }
    }
}
