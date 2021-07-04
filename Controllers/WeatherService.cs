using System.Net.Http;
using System.Threading.Tasks;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _client;

    public WeatherService(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> GetWeather(string cityName, string apiKey)
    {
        var URL = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={"9be8df5d4f00f3c1fa2c214a4382d1ce"}";
        var response = await _client.GetAsync(URL);
        return await response.Content.ReadAsStringAsync();
    }
}