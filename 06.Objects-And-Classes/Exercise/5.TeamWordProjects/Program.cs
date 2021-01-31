using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.TeamWordProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberTeams; i++)
            {
                string[] register = Console.ReadLine().Split("-").ToArray();
                string creator = register[0];
                string teamName = register[1];

                Team team = new Team(teamName,creator);


                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.Creator).Contains(creator);

                if (!isTeamNameExist)
                {
                    if (!isCreatorExist)//if false if not create a team
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else//we go here cus he already has a team created
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }
            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] actions = teamMembers.Split(new char[] {'-','>'}.ToArray());//array of chars new way
                string newUser = actions[0];
                string teamName = actions[2];


                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExi = teams.Select(x => x.Creator).Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Member).Any(x => x.Contains(newUser));//from one collection to another check in another collection

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExi||isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Member.Add(newUser);//new user in the team
                }
                teamMembers = Console.ReadLine();
            }

            Team[] disbandTeams = teams.OrderBy(x => x.TeamName).Where(x => x.Member.Count == 0).ToArray();//we take them and filter them
            Team[] fullTeam = teams.OrderByDescending(x => x.Member.Count)
                                                                            .ThenBy(x => x.TeamName)
                                                                            .Where(x => x.Member.Count > 0)
                                                                            .ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.Creator}");
                

                foreach (var member in team.Member.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }
            sb.AppendLine("Teams to disband:");

            foreach (Team item in disbandTeams)
            {
                sb.AppendLine(item.TeamName);
            }
            Console.WriteLine(sb.ToString());//takes everything inserted in string builder
        }
    }
    class Team
    {
        public Team(string teamName,string creator)//we dont put a list type in here
        {
            TeamName = teamName;
            Creator = creator;
            Member =new List<string>();//we gotta initialize the list or it doesn't exist
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> Member { get; set; }//list of members
    }
}
