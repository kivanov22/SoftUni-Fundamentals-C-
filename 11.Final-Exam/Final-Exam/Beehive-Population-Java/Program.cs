using System;

namespace Beehive_Population_Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPopulation = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            for (int i = 1; i <= years; i++)
            {
                initialPopulation += initialPopulation / 10 * 2;

                if (i % 5 == 0)
                {
                    initialPopulation -= initialPopulation / 50 * 5;
                }
                initialPopulation -= initialPopulation / 20 * 2;
            }
            Console.WriteLine($"Beehive population: {initialPopulation}");
        }
    }
}
