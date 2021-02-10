using System;

namespace Honey_Harvest
{
    class Program
    {
        //3ta zadacha
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double honey = 0;
            double percent = 0;
            switch (typeFlower)
            {
                case "Sunflower":
                    switch (season)
                    {
                        case "Spring":
                            honey = 10;
                            break;
                        case "Summer":
                            honey = 8;
                             break;
                        case "Autumn":
                            honey = 12;
                             break;
                    }
                    break;
                case "Daisy":
                    switch (season)
                    {
                        case "Spring":
                            honey = 12;
                            
                            break;
                        case "Summer":
                            honey = 8;
                            break;
                        case "Autumn":
                            honey = 6;
                            break;
                    }                  
                    break;
                case "Lavender":
                    switch (season)
                    {
                        case "Spring":
                            honey = 12;
                            break;
                        case "Summer":
                            honey = 8;
                            break;
                        case "Autumn":
                            honey = 6;
                            break;
                    }
                    break;   
                case "Mint":
                    switch (season)
                    {
                        case "Spring":
                            honey = 10;
                            percent = 0.10; //+
                            break;
                        case "Summer":
                            honey = 12;
                            break;
                        case "Autumn":
                            honey = 6;
                            break;
                    }
                    break;                    
            }
            

            double totalSum = numberFlowers * honey;

            if (season == "Autumn")
            {
                totalSum=totalSum* 0.95;
            }
            if(season == "Summer")
            {

                totalSum = totalSum + 0.10 * totalSum;
            }
            if( season == "Spring" && typeFlower == "Daisy" ||season=="Spring"&& typeFlower == "Mint")
            {

                totalSum = totalSum + 0.10 * totalSum;
            }

            Console.WriteLine($"Total honey harvested: {totalSum:f2}");

        }
    }
}
