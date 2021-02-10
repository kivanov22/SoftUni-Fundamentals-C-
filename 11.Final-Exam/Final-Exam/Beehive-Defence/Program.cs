using System;

namespace Beehive_Defence
{
    class Program
    {
        static void Main(string[] args)
        {

            //5-ta zadacha
            int numberBees = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int atack = int.Parse(Console.ReadLine());


            int beesHealth = 0;
            int bearHealth = 0;

            while (numberBees>=100)
            {

                for (int i = 1; i <= atack; i++)
                {
                    if (numberBees < 0)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left 0.");
                        return;
                    }
                    else if (numberBees < 100)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {Math.Abs(numberBees)}.");
                        return;
                    }
                    else if (health <= 0)
                    {
                        Console.WriteLine($"Beehive won! Bees left {numberBees}.");
                        return;
                    }
                    numberBees = numberBees - atack;
                    health = health - numberBees * 5;
                }
            }
           

        }
    }
}
