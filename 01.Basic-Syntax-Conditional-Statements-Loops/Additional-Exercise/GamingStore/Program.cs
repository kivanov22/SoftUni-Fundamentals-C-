using System;

namespace _3._3._GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());


            double spend = 0;
            double priceGame = 0;

            while (true)
            {
                string gameName = Console.ReadLine();

                 priceGame = 0;


                if (gameName == "Game Time")
                {
                    break;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                switch (gameName)
                {
                    case "OutFall 4":
                        priceGame = 39.99;
                        break;
                    case "CS: OG":
                        priceGame = 15.99;
                        break;
                    case "Zplinter Zell":
                        priceGame = 19.99;
                        break;
                    case "Honored 2":
                        priceGame = 59.99;
                        break;
                    case "RoverWatch":
                        priceGame = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        priceGame = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                        if (currentBalance >= priceGame)
                        {
                            spend += priceGame;
                            currentBalance -= priceGame;
                            Console.WriteLine($"Bought {gameName}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }


                }
                Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }

