using System;

namespace _1.BonusScoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double studentWithMaxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < countStudents; i++)
            {
                int currentStudentAttendace = int.Parse(Console.ReadLine());
                

               double total = ((1.0*currentStudentAttendace / lectures) * (5 + bonus));
                
                

                if (total>studentWithMaxBonus)
                {
                    studentWithMaxBonus = total;
                    maxAttendance = currentStudentAttendace;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(studentWithMaxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");


        }
    }
}
