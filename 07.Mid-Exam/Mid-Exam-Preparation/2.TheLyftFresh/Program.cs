using System;
using System.Linq;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            bool NoMorePeople = false;
            int wagonCapacity = 4;
            int difference = 0;
            bool isThereSpace = false;
            for (int i = 0; i < wagon.Length; i++)
            {
                if (wagon[i]>4)
                {
                    continue;
                }
                while (wagon[i] < 4)
                {
                    //wagon[i]++;
                    //peopleOnTheCurrentWagon++;
                  
                   if (wagon.Sum() == waitingPeople)
                    {
                        NoMorePeople = true;
                        break;
                    }
                  else  if (wagon[i] == 0)
                    {
                        wagon[i] += wagonCapacity;
                        waitingPeople -= wagonCapacity;
                    }
                    else if (wagon[i] < wagonCapacity)
                    {
                        int currentElement = wagon[i];
                        difference = wagonCapacity - currentElement;
                        waitingPeople -= wagon[i];
                        wagon[i] += difference;
                    }
                    else if (waitingPeople<wagonCapacity)
                    {
                        isThereSpace = true;
                        break;
                    }
                    //    if (peopleonTheLyft + peopleOnTheCurrentWagon == waitingPeople)
                    //{
                    //    NoMorePeople = true;
                    //    break;
                    //}

                    //peopleonTheLyft += peopleOnTheCurrentWagon;

                    //peopleOnTheCurrentWagon = 0;
                }
                if (NoMorePeople)
                {
                    break;
                }
            }
            if (waitingPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (isThereSpace)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            //else if (peopleonTheLyft == peopleWaitingForLyft && NoMorePeople == true)
            else if (wagon.All(w => w == 4) && NoMorePeople == true)
            {
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}
