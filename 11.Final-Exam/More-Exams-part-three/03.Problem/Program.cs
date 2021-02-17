using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //var guestNamesAndMeals = new Dictionary<string, string>();
            //var mealNames = new Dictionary<string, string>();
            var guestAndMeals = new Dictionary<string, string>();
            //var unlikedMeals = new Dictionary<string, string>();

            string command = Console.ReadLine();
            int count = 0;

            while (command != "Stop")
            {
                string[] cmdArgs = command.Split("-");
                string action = cmdArgs[0];
                string name = cmdArgs[1];
                string meal = cmdArgs[2];

                if (action == "Like")
                {


                    if (!guestAndMeals.ContainsKey(name))//if the name is not in the dictionary
                    {
                        guestAndMeals.Add(name, " " + meal);
                    }
                    else//add to existing
                    {
                        if (!guestAndMeals.ContainsValue(meal))
                        {
                            guestAndMeals[name] += ", " + meal;
                        }

                    }

                }
                else if (action == "Unlike")
                {
                    if (guestAndMeals.ContainsKey(name))
                    {

                        guestAndMeals[name] = "";
                        Console.WriteLine($"{name}doesn't like the{meal}.");
                    }


                    if (!guestAndMeals.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");

                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't have the {meal}in his/her collection.");
                    }

                    //if (!guestAndMeals.ContainsValue(meal))
                    //{

                    //    Console.WriteLine($"{name} doesn't have the {meal}in his/her collection.");
                    //}
                    count++;
                }


                command = Console.ReadLine();
            }
            foreach (var item in guestAndMeals.OrderByDescending(x => x.Value).OrderBy(x => x.Key))
            {

                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
