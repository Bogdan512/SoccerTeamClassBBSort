using System;

namespace SoccerTeamsRankingBubbleSortWithClass
{
    public class SoccerTeamRenewed
    {
         string name;
         int points;

        public SoccerTeamRenewed()
        {

        }

        public SoccerTeamRenewed(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public void BubbleSort(SoccerTeamRenewed[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = 0; j < teams.Length - 1; j++)
                {
                    if (teams[j].points < teams[j + 1].points)
                    {
                        Swap(teams, j, j + 1);
                        //int temp = teams[j].points;
                        //teams[j].points = teams[j + 1].points;
                        //teams[j].points = temp;
                    }
                }
            }
        }

         void Swap(SoccerTeamRenewed[] teams, int firstIndex, int secondIndex)
        {
            (int minIndex, int maxIndex) = GetMinMaxIndex(firstIndex, secondIndex);
            string message = "Swapping elements with indexes ({0}, {1}) and values ({2}, {3})";
            Console.WriteLine(string.Format(message, minIndex, maxIndex, teams[minIndex].name, teams[maxIndex].name));

            SoccerTeamRenewed temp = teams[minIndex];
            teams[minIndex] = teams[maxIndex];
            teams[maxIndex] = temp;
        }

         (int minIndex, int maxIndex) GetMinMaxIndex(int firstIndex, int secondIndex)
        {
            if (firstIndex > secondIndex)
                return (secondIndex, firstIndex);

            return (firstIndex, secondIndex);
        }

        public void Print(SoccerTeamRenewed[] teamsRanking)
        {
            for (int i = 0; i < teamsRanking.Length; i++)
                Console.WriteLine(teamsRanking[i].name + "- " + teamsRanking[i].points);
        }

        public SoccerTeamRenewed[] ReadTeams()
        {
            SoccerTeamRenewed[] result = new SoccerTeamRenewed[4];

            for (int i = 0; i < result.Length; i++)
            {
                string[] teamData = Console.ReadLine().Split('-');
                int points = Convert.ToInt32(teamData[1]) + Convert.ToInt32(teamData[2]);
                result[i] = new SoccerTeamRenewed(teamData[0], points);
            }

            return result;
        }
    }

    public class Program
    {
         void Main(string[] args)
        {
            SoccerTeamRenewed soccerTeam = new SoccerTeamRenewed();
            SoccerTeamRenewed[] teamsRanking = soccerTeam.ReadTeams();
            Console.WriteLine();
            soccerTeam.BubbleSort(teamsRanking);
            soccerTeam.Print(teamsRanking);
            Console.Read();
        }

        
    }
}
