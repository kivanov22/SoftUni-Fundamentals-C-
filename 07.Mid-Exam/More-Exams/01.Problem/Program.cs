using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupPeople = int.Parse(Console.ReadLine());
            double priceFuel = double.Parse(Console.ReadLine());
            double foodExpensePerPerson = double.Parse(Console.ReadLine());
            double oneNightPerson = double.Parse(Console.ReadLine());
            // double kilometers = double.Parse(Console.ReadLine());

            

            if (groupPeople > 10)
            {
                //25% discount
                oneNightPerson *= 0.75;
               

            }
            double sumFoodExpanse = foodExpensePerPerson * groupPeople * daysTrip;
            double priceAllNights = oneNightPerson * groupPeople * daysTrip;
            double totalExpanse = sumFoodExpanse + priceAllNights;

            for (int i = 1; i <= daysTrip; i++)
            {
                double kilometers = double.Parse(Console.ReadLine());
                totalExpanse += kilometers * priceFuel;
                //1548
                                                      //2598



                if (i %3== 0 || i % 5==0)
                {
                    
                    totalExpanse *= 1.4;
                        

                }

                if (i % 7 == 0)
                {
                    
                    totalExpanse -= totalExpanse / groupPeople;
                }
                if (totalExpanse > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(totalExpanse - budget):f2}$ more.");
                    return;
                }
                
            }
            Console.WriteLine($"You have reached the destination. You have {budget - totalExpanse:f2}$ budget left.");
            
        }
    }
}
