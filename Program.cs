using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Enter city name: ");
        var city = Console.ReadLine();

        var weatherClient = new WeatherClient("YOUR_API_KEY_HERE");
        var weather = await weatherClient.GetWeatherAsync(city);

        if (weather != null)
        {
            Console.WriteLine($"City: {weather.Name}");
            Console.WriteLine($"Temperature: {weather.Main.Temp}°C");
            Console.WriteLine($"Weather: {weather.Weather[0].Description}");
        }
        else
        {
            Console.WriteLine("Weather data not found.");
        }
    }
}