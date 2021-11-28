// See https://aka.ms/new-console-template for more information

using Refit;
using WebApi.Contract;
using WebApi.Sdk;


var weatherApi = RestService.For<IWeatherApi>("http://localhost:5064");
IEnumerable<WeatherForecast> forecast = await  weatherApi.GetWeatherForecasts();
Console.WriteLine("Get forecast result");
