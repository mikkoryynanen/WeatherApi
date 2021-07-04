using System.Threading.Tasks;

public interface IWeatherService 
{
    Task<string> GetWeather(string cityName, string apiKey);
}