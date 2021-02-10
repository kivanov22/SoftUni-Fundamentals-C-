using System;

namespace Beehive_Defence_Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int bearAtack = int.Parse(Console.ReadLine());

            while (bees>=100)
            {
                bees -= bearAtack;

                if (bees <0)
                {
                    bees = 0;
                }
                bearHealth -= bees * 5;
                if (bearHealth < 1)
                {
                    Console.WriteLine($"Beehive won! Bees left {bees}.");
                    break;
                }
            }
            if (bees < 100)
            {
                Console.WriteLine($"The bear stole the honey! Bees left {bees}.");

            }
            
        }
    }
}
