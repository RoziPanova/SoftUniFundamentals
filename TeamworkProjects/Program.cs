/*
2
John-PowerPuffsCoders
Tony-Tony is the best
Peter->PowerPuffsCoders
Tony->Tony is the best
end of assignment
3
Tanya-CloneClub
Helena-CloneClub
Tedy-SoftUni
George->softUni
George->SoftUni
Tatyana->Leda
John->SoftUni
Cossima->CloneClub
end of assignment
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    internal class Program
    {
        class Teams
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Member { get; set; }
            public Teams(string teamName, string creator)
            {
                this.TeamName = teamName;
                this.Creator = creator;
                Member = new List<string>();
            }
            public override string ToString()
            {
                return $"{TeamName}\n" +
                       $"- {Creator}\n" +
                       $"{GetOrderedMembers()}";
            }

            private object GetOrderedMembers()
            {
                Member=Member.OrderBy(name => name).ToList();
                string result = string.Empty;
                for (int i = 0; i < Member.Count - 1; i++)
                {
                    result += $"-- {Member[i]}\n";
                }
                result += $"-- {Member[Member.Count - 1]}";
                return result;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                Teams team = new Teams(input[1], input[0]);
                Teams sameTeamFound = teams.Find(x => x.TeamName == team.TeamName);
                Teams sameCreatorFound = teams.Find(x => x.Creator == team.Creator);
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                    continue;
                }
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }
                teams.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split("->");
                if (input[0] == "end of assignment")
                {
                    break;
                }
                bool teamAlreadyExists = teams.Any(x => x.TeamName == input[1]);
                if (teamAlreadyExists == false)
                {
                    Console.WriteLine($"Team {input[1]} does not exist!");
                    continue;
                }
                if (teams.Any(teams => teams.Creator == input[0]) || teams.Any(teams => teams.Member.Contains(input[0])))
                {
                    Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                    continue;
                }
                teams.First(x => x.TeamName == input[1]).Member.Add(input[0]);
            }
            List<Teams> leftTeams = teams.Where(x => x.Member.Count() > 0).ToList();
            List<Teams> disbandTeams = teams.Where(x => x.Member.Count() <= 0).ToList();
            leftTeams = leftTeams.OrderByDescending(x => x.Member.Count()).ThenBy(x => x.TeamName).ToList();
            disbandTeams = disbandTeams.OrderBy(x => x.TeamName).ToList();
            leftTeams.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Teams to disband:");
            disbandTeams.ForEach(x => Console.WriteLine(x.TeamName));
        }
    }
}
