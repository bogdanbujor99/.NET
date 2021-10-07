namespace WeatherData
{
        public class WeatherDay
        {
            private readonly int _day;
            private readonly int _minWeather;
            private readonly int _maxWeather;

            public WeatherDay(int day, int maxWeather, int minWeather)
            {
                this._day = day;
                this._minWeather = minWeather;
                this._maxWeather = maxWeather;
            }
            public int Day => _day;
            public int MinWeather => _minWeather;
            public int MaxWeather => _maxWeather;
        }
}