using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkTeams
{
    public class Team
    {
        public Team()
        {

        }

        public Team(string user, string team)
        {
            this.Creator = user;
            this.Name = team;
        }

        public string Creator { get; set; }

        public string Name { get; set; }

        public string Member { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string teamData = Console.ReadLine();

                string creator = teamData.Split("-")[0];
                string teamName = teamData.Split("-")[1];

                Team team = new Team(creator, teamName);

                if (TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                if (CreatorExists(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

                if (!TeamExists(teams, teamName) && !CreatorExists(teams, creator))
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(team);
                }
            }

            string memberInput = Console.ReadLine();

            while (memberInput != "end of assignment")
            {
                string memberName = memberInput.Split("->")[0];
                string memberTeam = memberInput.Split("->")[1];

                Team members = new Team(memberName,memberTeam);

                if (!TeamExists(teams, memberTeam))
                {
                    Console.WriteLine($"Team {memberTeam} does not exist!");
                }

                if (MemberExists(teams,memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {memberTeam}!");
                }

                if (TeamExists(teams, memberTeam) && !MemberExists(teams, memberName))
                {
                    int creatorIndex = teams.FindIndex(i => i.Name == memberTeam);
                    teams[creatorIndex].Member = memberName;
                }

                memberInput = Console.ReadLine();
            }
        }

        private static bool TeamExists(List<Team> teams, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.Name == teamName)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CreatorExists(List<Team> teams, string user)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == user)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool MemberExists(List<Team> teams, string user)
        {
            foreach (Team team in teams)
            {
                if (team.Member == user || team.Creator==user)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
