using Refit;
using WebApi.Contract;

namespace WebApi.Sdk
{
    public interface IWeatherApi
    {
        [Get("/weatherforecast")]
        Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();
    }
}
