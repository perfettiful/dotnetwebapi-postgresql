using Microsoft.EntityFrameworkCore;

namespace dotnetwebapi.Data
{
    public class WeatherData : IWeatherData
    {
        private readonly WeatherDbContext db;

        // need to use a db context
        public WeatherData(WeatherDbContext db)
        {
            this.db = db;
        }
        public WeatherForecast Add(WeatherForecast WeatherForecast)
        {
            db.WeatherForecasts.Add(WeatherForecast);
            return WeatherForecast;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public WeatherForecast Delete(int id)
        {
            var WeatherForecast = GetWeatherForecastById(id);
            if (WeatherForecast != null)
            {
                db.WeatherForecasts.Remove(WeatherForecast);
            }
            return WeatherForecast;
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            return db.WeatherForecasts.ToArray();
        }
        public WeatherForecast GetWeatherForecastById(int id)
        {
            return db.WeatherForecasts.Find(id);
        }

        public WeatherForecast Update(WeatherForecast updatedWeatherForecast)
        {
            var entity = db.WeatherForecasts.Attach(updatedWeatherForecast);
            entity.State = EntityState.Modified;
            return updatedWeatherForecast;
        }
    }
}