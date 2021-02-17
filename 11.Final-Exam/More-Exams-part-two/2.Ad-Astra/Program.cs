using System;
using System.Text.RegularExpressions;

namespace _2.Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            //[#\|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})*\1(?<calories>\d{1,5})\1
            //string pattern = @"([#\|])(?<food>[A-Z][a-z\s]+)(?<date>\d{2}\d{2}\d{2})(?<caloeries>[0-9]+)\1";
            string newPattern = @"([#\|])(?<food>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})*\1(?<calories>\d{1,5})\1";
                                                                             
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, newPattern);

            int totalCalories = 0;
            int dailyCalories = 2000;
            int days = 0;

            foreach (Match item in matches)
            {
                // string device = match.Groups[1].Value;
               
                int calories = int.Parse(item.Groups["calories"].Value);

                totalCalories += calories;
                days = totalCalories / dailyCalories;
                    
            }
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                string food = match.Groups["food"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {food}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
