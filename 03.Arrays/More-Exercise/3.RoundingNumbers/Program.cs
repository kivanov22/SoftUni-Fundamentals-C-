using System;
using System.Linq;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();// turn the console numbers to array

            int[] roundedNums = new int[nums.Length];//int collection take nums and store them to array,define array

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);// round away from zero style.
                Console.WriteLine($"{Convert.ToDecimal(nums[i])} => {Convert.ToDecimal(roundedNums[i])}");//Convert.ToDecimal i minava v judge
                
               // Console.WriteLine($"{nums[i]} => {Math.Round(nums[i], MidpointRounding.AwayFromZero)}");
            }


        }
    }
}
