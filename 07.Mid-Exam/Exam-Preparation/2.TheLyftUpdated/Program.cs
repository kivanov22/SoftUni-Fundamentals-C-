using System;
using System.Collections.Generic;
using System.Linq;

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
            bool wagonHasSpace = false;
            int wagonCapacity = 4;
            int difference = 0;
            for (int i = 0; i < wagon.Length; i++)
            {
                //int currentWagon = wagon[i]; 
                wagonHasSpace = false;
                if (wagon[i]>4)
                {
                    isThereSpace = true;
                    continue;
                }
               else if (peopleWaiting < wagonCapacity)
                {
                    wagon[i] += peopleWaiting;
                    peopleWaiting = 0;
                    isThereSpace = true;
                    break;
                }
               else if (wagon[i] == 0)
                {
                    wagon[i] += wagonCapacity;
                    peopleWaiting -= wagonCapacity;
                }
                else if (wagon[i] < wagonCapacity)
                {
                    int currentElement = wagon[i];
                    difference = wagonCapacity - currentElement;
                    peopleWaiting += difference;
                    wagon[i] += difference;
                    peopleWaiting -= wagonCapacity;


                }
            }
            if (isThereSpace)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagon));
            }
            else if (peopleWaiting == 0 && wagonHasSpace == true)
            {
                Console.WriteLine(String.Join(" ", wagon));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(' ', wagon));
            }



        }
    }
}