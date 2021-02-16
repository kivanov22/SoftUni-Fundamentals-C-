using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validDestinations = new List<string>();

            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";//we pused groups, and initilializing the cities names with location

            string destinations = Console.ReadLine();

            MatchCollection matches = Regex.Matches(destinations, pattern);
            int travelPoints = 0;

            foreach (Match destination in matches)
            {
                validDestinations.Add(destination.Groups["location"].Value);
                travelPoints += destination.Groups["location"].Value.Length;//finding the names of the cities length
            }
            Console.WriteLine("Destinations: " + string.Join(", ", validDestinations));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
