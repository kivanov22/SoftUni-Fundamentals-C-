using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string biggestKeg = "";
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                //π * r^2 * h.

                double volume= Math.PI *Math.Pow(radius,2) * height;//тук ползваме библиотека за пи и Мат.Поу за повдигане на втора


                if (volume>biggestVolume)
                {
                    biggestVolume= volume; // сравняваме обема на Кеговете
                    biggestKeg = model; // и според обема , определяме името на Кега с наи-висок обем

                }
            }
            Console.WriteLine(biggestKeg);




        }
    }
}
