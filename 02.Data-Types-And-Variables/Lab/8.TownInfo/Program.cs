using System;

namespace _8.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int are = int.Parse(Console.ReadLine());


            Console.WriteLine($"Town {city} has population of {population} and area {are} square km.");
            //"Town {town name} has population of {population} and area {area} square km"
        }
    }
}
