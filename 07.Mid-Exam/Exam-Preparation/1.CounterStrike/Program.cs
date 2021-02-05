using System;

namespace _1.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int battles = 0;
            int wins = 0;
            bool isWinner = true;

            while (input !="End of battle")
            {
                int distance = int.Parse(input);
                battles++;

                if (energy< distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWinner = false;
                    break;
                }

                wins++;
                energy -= distance;

                if (battles%3==0)
                {
                    energy += wins;
                }
                input = Console.ReadLine();
            }
            if (isWinner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}" );
            }
        }
    }
}
