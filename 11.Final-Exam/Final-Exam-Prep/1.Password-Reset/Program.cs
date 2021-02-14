using System;
using System.Text;

namespace _1.Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command!="Done")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];

                if (action== "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i%2!=0)
                        {
                            sb.Append(password[i]);
                           
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                   password= password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];

                    if (password.Contains(substring))
                    {
                        password =password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
