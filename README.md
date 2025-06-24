# 🌦️ Weather CLI App

A simple C# console application that fetches real-time weather information for a given city using the OpenWeatherMap API.

## 🔧 Features
- Fetch live weather based on city input
- Uses HttpClient to call OpenWeatherMap REST API
- JSON parsing using System.Text.Json

## 📦 Tech Stack
- C# (.NET 8)
- Console Application
- HttpClient & JSON Parsing

## 🚀 Run Instructions

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/weather-cli-csharp.git
    cd weather-cli-csharp
    ```

2. Replace the placeholder API key in `Program.cs` with your [OpenWeatherMap API](https://openweathermap.org/api) key.

3. Build and run the project:
    ```bash
    dotnet restore
    dotnet build
    dotnet run
    ```

## 📝 License
MIT