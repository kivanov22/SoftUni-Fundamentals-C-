using System;

namespace _1.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            double sum = 0.0;
            double taxes = 0.0;
            double finalPrice = 0.0;
            
            while (input != "special" && input != "regular")
            {
                double priceToNumber = double.Parse(input);

                if (priceToNumber < 0)
                {
                   
                    Console.WriteLine("Invalid price!");
                    priceToNumber = 0;
                }

                sum += priceToNumber;//total sum
                


                input = Console.ReadLine();
            }
            taxes = sum * 0.20;//taxes
            finalPrice = sum + taxes;//totalPrice 


            if (finalPrice==0)
            {
                Console.WriteLine("Invalid order!");
            }
               
            
           else if (input == "special")//if got mistake i should put is valid too here
            {
                double special = (finalPrice - 0.10 * finalPrice);
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {special:f2}$");

            }
            else if (input == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
            
        }
    }
}
