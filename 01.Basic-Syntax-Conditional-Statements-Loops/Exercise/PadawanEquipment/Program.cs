using System;

namespace _9.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double totalPriceL = Math.Ceiling(countOfStudents + 0.10 * countOfStudents)*priceLightsaber;
            double totalPriceR = priceRobes * countOfStudents;
            double totalPriceB = priceBelts * countOfStudents;
            
            int countBelts = countOfStudents/6;


            
            double totalAllEquipment = totalPriceL + totalPriceR + (totalPriceB-(countBelts*priceBelts));

            if (totalAllEquipment <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalAllEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalAllEquipment-amountOfMoney:f2}lv more.");
            }
                
        }
    }
}
            //for (int i = 1; i <= countOfStudents; i++)
            //{
            //    countBelts++;

            //    if (countBelts == 6)
            //    {
            //        countOfStudents -= 1;
            //    }


            //}