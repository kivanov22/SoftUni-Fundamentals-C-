using System;

namespace Honey_Winter_Reserves_Java_Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            double honeyForWinter = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double collectedHoney = 0;
            double beesHoney = 0;
            bool yes = false;
            while (input != "Winter has come")// dokato polu4im ot konzolata winter
            {
                for (int i = 1; i <= 6; i++)// za dnite cikul da vurti
                {
                    double yeld = double.Parse(Console.ReadLine());//stoinosti ot konzolata kolko med
                    collectedHoney += yeld;//prisvoqvame v ednata promenliva stoinostite na purvata pchela
                    beesHoney += yeld;  //
                }
                if (beesHoney<0)
                {
                    Console.WriteLine($"{input} was banished for gluttony");
                }
                if (collectedHoney >= honeyForWinter)
                {
                    Console.WriteLine($"Well done! Honey surplus {collectedHoney-honeyForWinter:f2}.");
                    yes = true;
                    break;
                }
                input = Console.ReadLine(); // novo ime na pchela

            }
            if (!yes)
            {
                Console.WriteLine($"Hard Winter! Honey needed {honeyForWinter-collectedHoney:f2}.");
            }


        }
    }
}
