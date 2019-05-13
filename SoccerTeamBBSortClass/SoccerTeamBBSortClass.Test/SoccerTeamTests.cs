using System;
using Xunit;
using SoccerTeamsRankingBubbleSortWithClass;

namespace SoccerTeamBBSortClass.Test
{
    public class SoccerTeamClassTests
    {
        [Fact]
        public void Test1()
        {
            SoccerTeamClass[] soccerTeams = new SoccerTeamClass[]
            {
                new SoccerTeamClass( "CFR", 35 ),
                new SoccerTeamClass( "UCLUJ",33 ),
                new SoccerTeamClass( "Steaua",28 ),
                new SoccerTeamClass( "CACAMACA",40 )
        };

            SoccerTeamClass[] expected = new SoccerTeamClass[]
            {
                new SoccerTeamClass( "CACAMACA",40 ),
                new SoccerTeamClass( "CFR", 35 ),
                new SoccerTeamClass( "UCLUJ",33 ),
                new SoccerTeamClass( "Steaua",28 )
            };

            //SoccerTeamClass soccerTeam = new SoccerTeamClass();
            //soccerTeam.BubbleSort(soccerTeams);
            SoccerTeamClass.BubbleSort(soccerTeams);
            Assert.Equal(expected, soccerTeams);
        }
    }
}
