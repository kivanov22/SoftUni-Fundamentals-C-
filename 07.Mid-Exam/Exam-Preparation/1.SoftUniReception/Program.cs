using System;

namespace _1.EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceFloor = double.Parse(Console.ReadLine());

            double priceEggs =  0.75 * priceFloor;
            double priceMilk = priceFloor + 0.25 * priceFloor;
            double priceOneMilk = priceMilk / 4;
            double totalPriceCozonac = priceEggs + priceFloor + priceOneMilk;//price for one cozonac
            //1l milk is 4 cozonacs
            int countCozonacs = 0;
            int coloredEggs = 0;

            while (budget>totalPriceCozonac)
            {
                budget -= totalPriceCozonac;
                countCozonacs++;
                coloredEggs += 3;

                if (countCozonacs%3==0)
                {
                    coloredEggs -= countCozonacs - 2;
                }


            }
            Console.WriteLine($"You made {countCozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
//Eggs 1 pack
//Flour	1 kg
//Milk	0.250 l
