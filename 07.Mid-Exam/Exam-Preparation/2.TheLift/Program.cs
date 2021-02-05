using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            bool isThereSpace = false;
            bool isTherePeopleAndSpots = false;
            int wagonCapacity = 4;
            int difference = 0;
            bool isTherePeopleWaiting = false;
            int wagonFull = wagon.Count(x => x == 4);

            for (int i = 0; i < wagon.Length; i++)
            {
                //int currentWagon = wagon[i]; 
                if (peopleWaiting <= 0)
                {
                    isTherePeopleWaiting = true;
                    if (wagonFull==4)//wagon.Count(x=>x==4)==wagonCapacity
                    {
                        isTherePeopleAndSpots = true;
                    }
                }

                if (peopleWaiting < wagonCapacity&& wagon.Length-1 !=4)
                {
                    
                    wagon[i] += peopleWaiting;
                    peopleWaiting = 0;
                    isThereSpace = true;
                    break;
                }
                if (wagon[i] == 0)
                {
                    wagon[i] += wagonCapacity;
                    peopleWaiting -= wagonCapacity;
                }
                else if (wagon[i] < wagonCapacity)
                {
                    int currentElement = wagon[i];
                    difference = wagonCapacity - currentElement;
                    peopleWaiting -= wagon[i];
                    wagon[i] += difference;
                    //peopleWaiting -= wagonCapacity;
                }
            }
            
            if (isThereSpace)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }

            else if (isTherePeopleAndSpots)//check if no people in que and wagons full
            {
                Console.WriteLine(String.Join(" ", wagon));
            }



        }
    }
}
