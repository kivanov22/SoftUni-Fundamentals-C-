using System;
using System.Diagnostics.CodeAnalysis;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int pokeTargetCount = 0;// broqch
            double percent = (double)pokePower * 0.50;//delime za procenta da polu4ime


            while (pokePower>=distance)//vurtime cikula dokato silata e pove4e ot razstoqnieto
            {
                pokePower -= distance;//vadime ot silata , razstoqnieto
                pokeTargetCount++;//count i dvete v nachaloto na cikula ne v kraq

                if (pokePower==percent && exhaustion!=0)//proverka dali silata e ravna na procenta, umorata e razlichno ot 0
                {
                    pokePower /= exhaustion;//ako e taka delim, ako ne izvajdame
                }
                
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeTargetCount);
        }
    }
}
