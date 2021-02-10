using System;

namespace Beehive_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            int intellect = int.Parse(Console.ReadLine());
            int strenght = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string type = "";

            if(intellect>=80 && strenght >= 80 && gender == "female")
            {
                type = "Queen Bee";
            }
            else if(intellect>=80&& strenght>0)//&& gender == "female" && gender == "male"
            {
                type = "Repairing Bee";
            }
            else if(intellect>=60 && strenght >= 0)
            {
                type = "Cleaning Bee";
            }
           else if(intellect >= 0 && strenght >= 80 && gender == "male")
            {
                type = "Drone Bee";
            }
           else if(intellect >= 0 && strenght >= 60 )
            {
                type = "Guard Bee";
            }
           else if(intellect >= 0 && strenght >= 0 )
            {
                type = "Worker Bee";
            }

            Console.WriteLine(type);
        }
    }
}
