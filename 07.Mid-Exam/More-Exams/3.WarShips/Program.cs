using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _3.WarShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pirateShip = Console.ReadLine().Split(">").ToList();
            List<string> warShip = Console.ReadLine().Split(">").ToList();
            int health = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input!= "Retire")
            {
                string[] commands = input.Split(" ");

                if (commands[0]=="Fire")
                {
                    int index = int.Parse(commands[1]);
                    int damage = int.Parse(commands[2]);

                    if (index>=0 && index<=warShip.Count)//pirate atacks warship
                    {
                        if (index<=0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            break;
                        }
                        warShip[index] =warShip[index-damage];
                    }
                }
                else if (commands[0]== "Defend")//warship atack pirate
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int damagePirate = int.Parse(commands[3]);
                   
                    if (pirateShip.Any(x=>startIndex==0) && pirateShip.Any(x=>endIndex==0))
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                    }

                }
                else if (commands[0]== "Repair")
                {
                    int repairIndex = int.Parse(commands[1]);
                    int healthIndex = int.Parse(commands[2]);

                    if (repairIndex>=0 && repairIndex<=health)
                    {
                        
                    }
                }
                else if (commands[0]== "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        string currentElement = pirateShip[i];

                        if (i < health)
                        {
                            count++;
                        }
                    }
                    if (true)
                    {
                        Console.WriteLine($"{count} sections need repair.");
                    }
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Pirate ship status: "+ string.Join("",pirateShip));
            Console.WriteLine($"Warship status: " + string.Join("", warShip));
        }
    }
}
