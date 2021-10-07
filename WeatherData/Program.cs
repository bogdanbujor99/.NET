using System;

namespace WeatherData
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthInfo = new MonthInfo("C:\\Users\\bujor\\RiderProjects\\Lab2\\WeatherData\\weather.dat");
            monthInfo.LowestDaySpread();
        }
    }
}