using System;
using System.Linq;


namespace _3.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighberhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            
            int jumpedPosition = 0;
            string command = Console.ReadLine();

            while (command != "Love!")
            {
               string[] cmdArgs = command.Split();
               int jumpLength = int.Parse(cmdArgs[1]);
               jumpedPosition += jumpLength;//we save our index so it will not go back again from 0 

                if (jumpedPosition >=0 && jumpedPosition<neighberhood.Length)//check if index is valid, in range of array
                {
                    neighberhood[jumpedPosition] -= 2;
                }
                else
                {
                    jumpedPosition = 0;
                    neighberhood[jumpedPosition] -= 2;
                }

                if (neighberhood[jumpedPosition]==0)//check position 
                {
                    Console.WriteLine($"Place {jumpedPosition} has Valentine's day.");
                }
                else if (neighberhood[jumpedPosition]<0)
                {
                    Console.WriteLine($"Place {jumpedPosition} already had Valentine's day.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {jumpedPosition}.");


            int successCount = neighberhood.Count(x => x == 0);//how many elements match a condition 0
            int failCount = neighberhood.Count(x => x > 0);

            if (failCount==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
        }
    }
}
