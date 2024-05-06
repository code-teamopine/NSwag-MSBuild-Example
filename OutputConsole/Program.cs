// See https://aka.ms/new-console-template for more information

using NSwagClient;

var httpClient = new HttpClient();

httpClient.BaseAddress = new Uri("https://localhost:7099");

var client = new Client("https://localhost:7099", httpClient);


var weathers = await client.GetWeatherForecastAsync();

foreach (var weather in weathers)
{
    Console.WriteLine(weather.Summary);
}

Console.ReadKey();
