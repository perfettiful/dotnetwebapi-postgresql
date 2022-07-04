namespace dotnetwebapi.Data
{
    public interface IWeatherData
    {
        IEnumerable<WeatherForecast> GetAll();
        WeatherForecast Add(WeatherForecast weather);
        WeatherForecast Update(WeatherForecast updatedWeather);
        WeatherForecast Delete(int id);
    }
}