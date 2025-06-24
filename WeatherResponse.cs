using System.Text.Json.Serialization;

public class WeatherResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("main")]
    public MainInfo Main { get; set; }

    [JsonPropertyName("weather")]
    public WeatherInfo[] Weather { get; set; }
}

public class MainInfo
{
    [JsonPropertyName("temp")]
    public float Temp { get; set; }
}

public class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; set; }
}