using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class WeatherClient
{
    private readonly string _apiKey;
    private readonly HttpClient _http;

    public WeatherClient(string apiKey)
    {
        _apiKey = apiKey;
        _http = new HttpClient();
    }

    public async Task<WeatherResponse?> GetWeatherAsync(string city)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";

        var response = await _http.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<WeatherResponse>(json);
        }
        return null;
    }
}