// See https://aka.ms/new-console-template for more information

using NSwagClient;

const string BaseUrl = "https://localhost:7099";

var client = new Client(BaseUrl, new HttpClient
{
    BaseAddress = new Uri(BaseUrl)
});


var weathers = await client.GetWeatherForecastAsync();

foreach (var weather in weathers)
{
    Console.WriteLine($"{weather.Date}\t{weather.TemperatureC}°C\t{weather.TemperatureF}°F\t{weather.Summary}");
}

Console.ReadKey();
