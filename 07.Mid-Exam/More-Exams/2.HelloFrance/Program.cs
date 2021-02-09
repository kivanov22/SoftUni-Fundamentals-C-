using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] formats = { "->", "|" };
            string[] items = Console.ReadLine().Split("|");
            double budget = double.Parse(Console.ReadLine());

            List<double> newPrices = new List<double>();//empty list
            double profit = 0;

            for (int i = 0; i < items.Length; i++)
            {
                string[] itemData = items[i].Split("->");//the whole Clothes->43.30
                string type = itemData[0];//type like clothes
                double price = double.Parse(itemData[1]);//here we take the number only
                double maxPrice = 0;

                switch (type)//switch for type of clothes
                {
                    case "Clothes":
                        maxPrice = 50.00;
                        break;
                    case "Shoes":
                        maxPrice = 35.00;
                        break;
                    case "Accessories":
                        maxPrice = 20.50;
                        break;
                    
                }
                if (price<=maxPrice && budget>=price)
                {
                    budget -= price;
                    newPrices.Add(price * 1.4);
                    profit += price * 0.40;
                }

            }
            budget += newPrices.Sum();//we add the newPrices sum to the budget, newPrices is a list for the reseling items

            StringBuilder sb = new StringBuilder();

            foreach (var price in newPrices)
            {
                sb.Append($"{price:f2}" + " ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());

            Console.WriteLine($"Profit: {profit:f2}");//"60.62 35.35 51.13 "<- space at the end before TrimEnd // after "60.62 35.35 51.13"

            if (budget>=150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
//Clothes 50.00
//Shoes 35.00
//Accessories 20.50
