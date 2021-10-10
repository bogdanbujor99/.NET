using System;
using SoccerLeagueTable;

namespace DryFusion
{
    class Program
    {
        private static void Main(string[] args)
        {
            InfoFile info = new InfoFile("WeatherData",
                "C:\\Users\\bujor\\RiderProjects\\Lab2\\WeatherData\\weather.dat");
            info.Spread();
        }
    }
}