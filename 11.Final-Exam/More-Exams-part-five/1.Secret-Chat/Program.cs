using System;
using System.Linq;

namespace _1.Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:");
                string action = tokens[0];

                switch (action)
                {
                    case "InsertSpace":
                        int index = int.Parse(tokens[1]);

                      concealedMessage =  concealedMessage.Insert(index, " ");
                        Console.WriteLine(concealedMessage);
                        break;
                    case "Reverse":
                        string text = tokens[1];
                       

                        if (concealedMessage.Contains(text))
                        {

                            int findIndex = concealedMessage.IndexOf(text);
                            string testString = text;
                            string secondPart = new string(testString.ToCharArray().Reverse().ToArray());

                            concealedMessage = concealedMessage.Remove(findIndex, text.Length);
                            
                            //concealedMessage = concealedMessage.Insert(findIndex,secondPart);//problem in inserting
                            concealedMessage = concealedMessage.Insert(concealedMessage.Length, secondPart);

                           

                            Console.WriteLine(concealedMessage);
                        }
                        else
                        {

                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        text = tokens[1];
                        string replacement = tokens[2];

                       concealedMessage= concealedMessage.Replace(text, replacement);
                        Console.WriteLine(concealedMessage);
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
