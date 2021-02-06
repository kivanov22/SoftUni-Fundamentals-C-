using System;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < field.Length; i++)
            {
                var currentChar = field[i];

                if (currentChar=='>')
                {
                    bomb += int.Parse(field[i + 1].ToString());//we take the bomb 
                    continue;
                }

                if (bomb>0)//if the bomb has number in it
                {
                    field = field.Remove(i, 1);
                    i--;//so our indexes don't mess up
                    bomb --;
                }
            }
            Console.WriteLine(field);
        }
    }
}
