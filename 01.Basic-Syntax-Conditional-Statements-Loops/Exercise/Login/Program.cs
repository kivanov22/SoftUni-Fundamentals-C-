using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int times = 0;

            while (true)
            {
                string currentUser = Console.ReadLine();

                if (currentUser != password)
                {
                    times++;

                    if (times == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else 
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
            }
        }
    }
}
