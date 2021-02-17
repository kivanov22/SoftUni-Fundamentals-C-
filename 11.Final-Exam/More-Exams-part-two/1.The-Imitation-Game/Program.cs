using System;

namespace _1.The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] cmdArgs = command.Split("|");
                string action = cmdArgs[0];

                if (action == "Move")
                {
                    int numberLetters = int.Parse(cmdArgs[1]);//number of letters to take

                    string takeThree = message.Substring(0, numberLetters);//first 3

                    message = message.Remove(0, numberLetters);                    
                 // string lettersLeft = message.Substring(numberLetters, message.Length-numberLetters);
                //others
                    message = message.Insert(message.Length , takeThree);

                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    message = message.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    message = message.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
