using System;

namespace _1.DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int numMonths = int.Parse(Console.ReadLine());

            double moneySaved = 0;
            for (int i = 1; i <= numMonths; i++)
            {
                

                if (i%2==1)//odd month not every not every 3rd
                {
                    moneySaved -= moneySaved * 0.16;
                }
                else if (i%4==0)
                {
                    moneySaved += moneySaved * 0.25;
                }
                moneySaved += journeyCost * 0.25;
            }
            if (moneySaved>=journeyCost)
            {
                double haveMoney = moneySaved - journeyCost;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {haveMoney:f2}lv. for souvenirs.");
            }
            else /*if(moneySaved<journeyCost)*/
            {
                double noMoney = journeyCost - moneySaved;
                Console.WriteLine($"Sorry. You need {noMoney:f2}lv. more.");    
            }
        }
    }
}
