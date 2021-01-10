using System;
using System.Numerics;

namespace _11.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowBalls = int.Parse(Console.ReadLine());

            
            int maxSnowBallSnow = 0;
            int maxSnowBallTime = 0;
            int maxSnowBallQuality = 0;
            BigInteger maxSnowBallValue = 0;

            for (int i = 0; i < numberSnowBalls; i++)
            {
              int   snowBallSnow = int.Parse(Console.ReadLine());
              int   snowBallTime = int.Parse(Console.ReadLine());
              int  snowBallQuality = int.Parse(Console.ReadLine());

              BigInteger  snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime),snowBallQuality);//vmesto Math.Pow direktno BigInteger.Pow
                
                if (snowBallValue>=maxSnowBallValue)
                {
                    
                    maxSnowBallSnow = snowBallSnow;
                    maxSnowBallTime = snowBallTime;
                    maxSnowBallQuality = snowBallQuality;
                    maxSnowBallValue = snowBallValue;
                }

            }
            Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = {maxSnowBallValue} ({maxSnowBallQuality})");

        }
    }
}
