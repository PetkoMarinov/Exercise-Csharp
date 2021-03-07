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

        public Team(string user, string team, List<string> members)
        {
            this.Creator = user;
            this.Name = team;
            this.Members = members;
        }

        public string Creator { get; set; }

        public string Name { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string teamData = Console.ReadLine();

                string creator = teamData.Split("-")[0];
                string teamName = teamData.Split("-")[1];

                List<string> members = new List<string>();

                Team team = new Team(creator, teamName, members);

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

                if (!TeamExists(teams, memberTeam))
                {
                    Console.WriteLine($"Team {memberTeam} does not exist!");
                }

                if (MemberExists(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {memberTeam}!");
                }

                if (TeamExists(teams, memberTeam) && !MemberExists(teams, memberName))
                {
                    int teamIndex = teams.FindIndex(team => team.Name == memberTeam);
                    teams[teamIndex].Members.Add(memberName);
                }

                memberInput = Console.ReadLine();
            }

            List<Team> teamsToDisband = teams
                    .OrderBy(x => x.Name)
                    .Where(x => x.Members.Count == 0)
                    .ToList();

            teams = teams
                    .OrderByDescending(x => x.Members.Count)
                    .ThenBy(x => x.Name)
                    .Where(x => x.Members.Count > 0)
                    .ToList();

            foreach (var team in teams.Where(x => x.Members.Count > 0))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                team.Members.Sort();

                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var disbanded in teamsToDisband)
            {
                Console.WriteLine(disbanded.Name);
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

        private static bool CreatorExists(List<Team> teams, string creator)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == creator)
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
                if (team.Members.Contains(user) || team.Creator == user)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
