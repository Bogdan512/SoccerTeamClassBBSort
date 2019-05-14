using System;
using Xunit;
using SoccerTeamsRankingBubbleSortWithClass;

namespace SoccerTeamBBSortClass.Test
{
    public class SoccerTeamRenewedTests
    {
        [Fact]
        public void Test1()
        {
            SoccerTeamRenewed[] soccerTeams = new SoccerTeamRenewed[]
            {
                new SoccerTeamRenewed( "CFR", 35 ),
                new SoccerTeamRenewed( "UCLUJ",33 ),
                new SoccerTeamRenewed( "Steaua",28 ),
                new SoccerTeamRenewed( "CACAMACA",40 )
        };

            SoccerTeamRenewed[] expected = new SoccerTeamRenewed[]
            {
                new SoccerTeamRenewed( "CACAMACA",40 ),
                new SoccerTeamRenewed( "CFR", 35 ),
                new SoccerTeamRenewed( "UCLUJ",33 ),
                new SoccerTeamRenewed( "Steaua",28 )
            };

            SoccerTeamRenewed soccerTeam = new SoccerTeamRenewed();
            soccerTeam.BubbleSort(soccerTeams);
            Assert.Equal(expected, soccerTeams);
        }
    }
}
