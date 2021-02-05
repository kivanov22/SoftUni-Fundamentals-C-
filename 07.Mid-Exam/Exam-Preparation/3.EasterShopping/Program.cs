using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;

namespace _3.EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopsToVisit = Console.ReadLine().Split().ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split();

                switch (cmdArgs[0])
                {
                    case "Include":
                        string shop = cmdArgs[1];
                        shopsToVisit.Add(shop);
                        break;
                    case "Visit":
                        string firstLast = cmdArgs[1];
                        int numberOfShops = int.Parse(cmdArgs[2]);
                        
                        if (numberOfShops > shopsToVisit.Count)
                        {
                           
                        }
                        else if (firstLast == "first")
                        {
                            shopsToVisit.RemoveRange(0, numberOfShops);
                        }
                        else if (firstLast == "last")
                        {
                            shopsToVisit.RemoveRange(shopsToVisit.Count - numberOfShops, numberOfShops);
                        }
                        break;
                    case "Prefer":
                        int shopIndex1 = int.Parse(cmdArgs[1]);
                        int shopIndex2 = int.Parse(cmdArgs[2]);
                        //shopList.length > firstIndex && shopList.length > secondIndex) {
                        //shopsToVisit.Count > 0 && shopIndex1 >= 0 && shopIndex2 >= 0 && shopIndex1 <= shopsToVisit.Count && shopIndex2 <= shopsToVisit.Count
                        //my long check if was wrong 
                        if (shopsToVisit.Count>shopIndex1 && shopsToVisit.Count>shopIndex2)
                        {
                            string currentElement = shopsToVisit[shopIndex1];
                            shopsToVisit[shopIndex1] = shopsToVisit[shopIndex2];
                            shopsToVisit[shopIndex2] = currentElement;
                        }
                        break;
                    case "Place":
                        string shoping = cmdArgs[1];
                        int shopIndex = int.Parse(cmdArgs[2]);
                        //shopList.length > index + 1)
                        //shopIndex < shopsToVisit.Count && shopIndex >= 0
                        //my wrong check
                        if (shopsToVisit.Count>shopIndex && shopIndex>=0)
                        {
                            shopsToVisit.Insert(shopIndex + 1, shoping);
                        }
                        break;


                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shopsToVisit));
        }
    }
}
