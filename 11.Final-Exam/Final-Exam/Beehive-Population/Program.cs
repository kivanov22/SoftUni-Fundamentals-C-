using System;

namespace Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            //4ta zadacha
            int startingPopulation = int.Parse(Console.ReadLine());
            int endYears = int.Parse(Console.ReadLine());

            int newBees = 0;
            int deadBees = 0;
            int migBees = 0;

            for (int year = 1; year <= endYears; year++)
            {
                 
                if (year ==5)
                {
                    newBees = (startingPopulation / 10) * 2;
                    startingPopulation += newBees;

                    migBees = (startingPopulation / 50) * 5;
                    startingPopulation -= migBees;

                    deadBees = (startingPopulation / 20) * 2;
                    startingPopulation -= deadBees;
                }
                else if (startingPopulation >= 10)
                {
                    newBees = (startingPopulation / 10) * 2;
                    startingPopulation += newBees;

                    deadBees = (startingPopulation / 20) * 2;
                    startingPopulation -= deadBees;
                }
            }
            Console.WriteLine($"Beehive population: {startingPopulation}");
        }
    }
}
