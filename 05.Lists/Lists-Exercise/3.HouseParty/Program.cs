﻿using System;
using System.Collections.Generic;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string guestName = cmdArg[0];

                if (cmdArg.Length >3)
                {
                    if (guests.Contains(guestName))
                    {
                        guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(guestName))
                    {
                        guests.Add(guestName);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
