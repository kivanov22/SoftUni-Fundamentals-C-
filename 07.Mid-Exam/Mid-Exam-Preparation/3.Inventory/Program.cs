using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                //char[] determine = { '-', ':',' ' }; 
                string[] determine={" - ",":","," };
                string[] command = input.Split(determine,StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string item = command[1];

                if (action == "Collect")
                {
                    if (!collection.Contains(item))
                    {
                        collection.Add(item);
                    }
                }
                else if (action == "Drop")
                {
                    if (collection.Contains(item))
                    {
                        //int index = collection.FindIndex(x => x == item);
                        collection.Remove(item);
                    }
                }
                else if (action == "Combine Items")
                {
                    string newItem = command[2];
                   
                    if (collection.Contains(item))
                    {
                        int index = collection.FindIndex(x=>x==item);
                        collection.Insert(index+1, newItem);
                    }
                }
                else if (action == "Renew")
                {
                    if (collection.Contains(item))
                    {
                        
                        collection.Remove(item);
                        collection.Add(item);
                        
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",collection));
        }
    }
}
