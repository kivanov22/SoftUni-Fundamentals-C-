using System;

namespace _1.SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double priceFuelKm = double.Parse(Console.ReadLine());
            double foodExpPerPerson = double.Parse(Console.ReadLine());
            double priceRoomPerPerson = double.Parse(Console.ReadLine());

            double foodExpanses = 0;
            double priceHotelNights = 0;

            if (groupOfPeople > 10)
            {
                priceRoomPerPerson *= 0.75;//a 25% discount from the total hotel expenses. 
            }
            foodExpanses = foodExpPerPerson * groupOfPeople * daysOfTrip;

            priceHotelNights = priceRoomPerPerson * groupOfPeople * daysOfTrip;//out of the for loop,not inside

            double currentTotalExp = foodExpanses + priceHotelNights;
            for (int i = 1; i <= daysOfTrip; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());



                currentTotalExp += travelledDistance * priceFuelKm;




                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentTotalExp *=  1.4;//are 40% of the current value of the expenses
                }
                if (i % 7 == 0)
                {
                    currentTotalExp -= currentTotalExp / groupOfPeople;

                }
                if (currentTotalExp > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(currentTotalExp-budget):f2}$ more.");
                    return;
                }

            }
            Console.WriteLine($"You have reached the destination. You have {(budget-currentTotalExp):f2}$ budget left.");


        }
    }
}
