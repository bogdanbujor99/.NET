using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WeatherData
{
    public class MonthInfo
    {
        private readonly List<WeatherDay> _dates = new List<WeatherDay>();
        private int _lowestSpread;
        private WeatherDay _lowestDaySpread;
        public MonthInfo(string path)
        {
            for (var i = 2; i < File.ReadAllLines(path).Length-1; i++)
            {
                var words = File.ReadAllLines(path)[i].Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
                var weatherDay = new WeatherDay(int.Parse(words[0]), int.Parse(words[1]), int.Parse(words[2]));
                _dates.Add(weatherDay);
            }
        }
        public void LowestDaySpread()
        {
            _lowestSpread = _dates.Any() ? _dates.Min(weatherDay => weatherDay.MaxWeather - weatherDay.MinWeather) : 0;
            _lowestDaySpread = _dates.Find(weatherDay => weatherDay.MaxWeather - weatherDay.MinWeather == _lowestSpread);
            Console.WriteLine(_lowestDaySpread!= null ? _lowestDaySpread.Day : "NOT EXIST");
        }
    }
}