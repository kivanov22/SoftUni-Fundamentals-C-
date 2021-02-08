using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _1.WiningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] winingSymbols = { "@", "#", "$", "^" };

            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";//find exactly 6 symbols 
            Regex regex = new Regex(pattern);

            var result = new StringBuilder();

            foreach (var ticket in tickets)//check each ticket
            {


                if (ticket.Length != 20)//if ticket not valid
                {
                    result.Append($"invalid ticket{Environment.NewLine}");
                    continue;
                }


                var leftMatch = regex.Match(ticket.Substring(0, 10));//take the left part
                var rightMatch = regex.Match(ticket.Substring(10));//take the right part 
                var minLength = Math.Min(leftMatch.Length, rightMatch.Length);

                if (!leftMatch.Success || !rightMatch.Success)//if they dont't match
                {
                    result.Append($"ticket \"{ticket}\" - no match{Environment.NewLine}");// \"{ticket}\" giving it boundaries 
                    continue;
                }

                var leftPart = leftMatch.Value.Substring(0, minLength);
                var rightPart = rightMatch.Value.Substring(0, minLength);

                if (leftPart.Equals(rightPart))
                {
                    if (leftPart.Length == 10)
                    {
                        result.Append($"ticket \"{ticket}\" - {minLength}{leftPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                    }
                    else
                    {
                        result.Append($"ticket \"{ ticket}\" - {minLength}{leftPart.Substring(0, 1)}{Environment.NewLine}");
                    }

                }

                else
                {
                    result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
                }
            }

            Console.Write(result.ToString());


            //1.check if valid ticket 20 characters which means Lenght
            //2.wining symbols pattern
            //3.count of wining symbols
            //4.checks sides of symbols and has to repeat 6 times
            //5.if symbol repeat 10 times its a jackpot , 
            //6.
        }
    }
}
