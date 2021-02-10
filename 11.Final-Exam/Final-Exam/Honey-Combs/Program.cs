using System;

namespace Honey_Combs
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberBee = int.Parse(Console.ReadLine());
            double numberFlowers = int.Parse(Console.ReadLine());

            double totalHoney = numberBee * numberFlowers * 0.21;
            double howMuch = Math.Floor(totalHoney / 100);
            double diffHoney = totalHoney - 100*howMuch;

            Console.WriteLine($"{Math.Floor(howMuch)} honeycombs filled.");
            Console.WriteLine($"{diffHoney:f2} grams of honey left.");
        }
    }
}
