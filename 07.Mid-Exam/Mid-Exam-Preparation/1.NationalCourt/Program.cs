using System;

namespace _1.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int answerPerHour = employee1 + employee2 + employee3;
            int hour = 0;


            while (peopleCount>0)//we loop though peopleCount till there is no 
            {
                peopleCount -= answerPerHour;//till we have 0 and loop ends
                hour++;

                if (hour%4==0)//4,8,16 work
                {
                    hour++;

                }
            }
            Console.WriteLine($"Time needed: {hour}h.");
            //"Time needed: {time}h."
        }
    }
}
