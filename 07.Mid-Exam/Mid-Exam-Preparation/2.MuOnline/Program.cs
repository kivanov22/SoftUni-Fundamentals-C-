using System;
using System.Linq;

namespace _2.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonRooms = Console.ReadLine().Split("|").ToArray();
            int initialHp = 100;
            int initialBitcoins = 0;
            int countRooms = 0;
            bool ifMadeIt = true;

            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string[] tokens = dungeonRooms[i].Split();
                string action = tokens[0];
                int number = int.Parse(tokens[1]);
                countRooms++;

                if (action == "potion")
                {
                    int currentHP = initialHp;
                    initialHp += number;

                    if (initialHp > 100)
                    {
                        initialHp = 100;
                        int amount = 100 - currentHP;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                    }
                    Console.WriteLine($"Current health: {initialHp} hp.");
                }
               else if (action =="chest")
                {
                    initialBitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    initialHp -= number;
                    if (initialHp<=0)
                    {
                        Console.WriteLine($"You died! Killed by {action}.");
                        Console.WriteLine($"Best room: {countRooms}");
                        ifMadeIt = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {action}.");
                        
                    }
                }
            }
            if (ifMadeIt)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHp}");
            }
        }
    }
}
