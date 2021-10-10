using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoccerLeagueTable
{
    public class LeagueInfo
    {
        private List<InfoTeam> _teams = new List<InfoTeam>();
        private int _smallestDifference;
        private InfoTeam _teamSmallestDifference;

        public List<InfoTeam> Teams
        {
            get => _teams;
            set => _teams = value;
        }

        public int SmallestDifference
        {
            get => _smallestDifference;
            set => _smallestDifference = value;
        }

        public InfoTeam TeamSmallestDifference1
        {
            get => _teamSmallestDifference;
            set => _teamSmallestDifference = value;
        }
        
        public LeagueInfo(){}
        public LeagueInfo(string path)
        {
            for (var i = 1; i < File.ReadAllLines(path).Length; i++)
            {
                var words = File.ReadAllLines(path)[i].Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length == 1) continue;
                var team = new InfoTeam(words[1], int.Parse(words[6]), int.Parse(words[8]));
                _teams.Add(team);
            }
        }
        public void TeamSmallestDifference()
        {
            _smallestDifference = _teams.Any() ? _teams.Min(infoTeam => Math.Abs(infoTeam.For - infoTeam.Against)) : 0;
            _teamSmallestDifference = _teams.Find(infoTeam => Math.Abs(infoTeam.For - infoTeam.Against) ==  _smallestDifference);
            Console.WriteLine(_teamSmallestDifference != null ? _teamSmallestDifference.Name : "NOT EXIST");
        }
    }
}