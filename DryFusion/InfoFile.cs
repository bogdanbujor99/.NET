using System;
using System.IO;
using System.Linq;
using SoccerLeagueTable;
using WeatherData;

namespace DryFusion
{
    public class InfoFile
    {
        private readonly object _classType;
        
        public InfoFile(string type, string path)
        {
            switch (type)
            {
                case "WeatherData":
                    var monthInfo = new MonthInfo();
                    for (var i = 2; i < File.ReadAllLines(path).Length-1; i++)
                    {
                        var words = File.ReadAllLines(path)[i].Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
                        var weatherDay = new WeatherDay(int.Parse(words[0]), int.Parse(words[1]), int.Parse(words[2]));
                        monthInfo.Dates.Add(weatherDay);
                    }
                    _classType = monthInfo;
                    break;
                
                case "SoccerLeagueTable":
                    var leagueInfo = new LeagueInfo();
                    for (var i = 1; i < File.ReadAllLines(path).Length; i++)
                    {
                        var words = File.ReadAllLines(path)[i].Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length == 1) continue;
                        var team = new InfoTeam(words[1], int.Parse(words[6]), int.Parse(words[8]));
                        leagueInfo.Teams.Add(team);
                    }

                    _classType = leagueInfo;
                    break;
                default:
                    Console.WriteLine("Erroneous dates");
                    break;
            }
        }

        public void Spread()
        {
            Console.WriteLine(_classType.GetType().ToString());
            switch (_classType.GetType().ToString())
            {
                case "SoccerLeagueTable.LeagueInfo":
                    var leagueInfo = (LeagueInfo)_classType;
                    leagueInfo.SmallestDifference = leagueInfo.Teams.Any() ? leagueInfo.Teams.Min(infoTeam => Math.Abs(infoTeam.For - infoTeam.Against)) : 0;
                    leagueInfo.TeamSmallestDifference1 = leagueInfo.Teams.Find(infoTeam => Math.Abs(infoTeam.For - infoTeam.Against) ==  leagueInfo.SmallestDifference);
                    Console.WriteLine(leagueInfo.TeamSmallestDifference1!= null ? leagueInfo.TeamSmallestDifference1.Name : "NOT EXIST");
                    break;
                case "WeatherData.MonthInfo":
                    var monthInfo = (MonthInfo)_classType;
                    monthInfo.LowestSpread = monthInfo.Dates.Any() ? monthInfo.Dates.Min(weatherDay => weatherDay.MaxWeather - weatherDay.MinWeather) : 0;
                    monthInfo.LowestDaySpread1 =  monthInfo.Dates.Find(weatherDay => weatherDay.MaxWeather - weatherDay.MinWeather ==  monthInfo.LowestSpread);
                    Console.WriteLine( monthInfo.LowestDaySpread1!= null ?  monthInfo.LowestDaySpread1.Day : "NOT EXIST");
                    break;
                default:
                    Console.WriteLine("Wrong Initialization");
                    break;
            }
        }
    }
}