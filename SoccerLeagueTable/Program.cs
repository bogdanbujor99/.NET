using System;

namespace SoccerLeagueTable
{
    class Program
    {
        private static void Main(string[] args)
        {
            var leagueInfo = new LeagueInfo("C:\\Users\\bujor\\RiderProjects\\Lab2\\SoccerLeagueTable\\football.dat");
            leagueInfo.TeamSmallestDifference();
        }
    }
}