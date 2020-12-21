using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;
            //double pricePerPerson = 0;
            //switch (day)
            //{
            //    case "Students":
            //        price = 8.45;
            //        break;
            //    case "Business":
            //        price = 10.90;
            //        break;
            //    case "Regular":
            //        price = 15;
            //        break;
                
            //}

            if(groupType == "Students"&& day == "Friday")
            {
                price = 8.45;
            }
            else if(groupType =="Business"&& day == "Friday")
            {
                price = 10.90;
            }
            else if (groupType == "Regular" && day == "Friday")
            {
                price = 15;
            }
            if (groupType == "Students" && day == "Saturday")
            {
                price = 9.80;
            }
            else if (groupType == "Business" && day == "Saturday")
            {
                price = 15.60;
            }
            else if (groupType == "Regular" && day == "Saturday")
            {
                price = 20;
            }
            if (groupType == "Students" && day == "Sunday")
            {
                price = 10.46;
            }
            else if (groupType == "Business" && day == "Sunday")
            {
                price = 16;
            }
            else if (groupType == "Regular" && day == "Sunday")
            {
                price = 22.50;
            }
            totalPrice = numberPeople * price;
            //totalPrice += pricePerPerson;

            if (groupType=="Students"&& numberPeople >= 30)
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if(groupType == "Business" && numberPeople >= 100)
            {
               totalPrice -= 10*price;
            }
            else if(groupType=="Regular"&& numberPeople>=10 && numberPeople <= 20)
            {
                totalPrice = totalPrice - 0.5 * totalPrice;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
