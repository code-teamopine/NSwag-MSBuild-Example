// See https://aka.ms/new-console-template for more information

using NSwagClient.Client1;
using NSwagClient.Client2;

const string BaseUrl1 = "https://localhost:7099";
const string BaseUrl2 = "https://localhost:7135";

var client1 = new N1Client(BaseUrl1, new HttpClient
{
    BaseAddress = new Uri(BaseUrl1)
});

var client2 = new N2Client(BaseUrl2, new HttpClient
{
    BaseAddress = new Uri(BaseUrl1)
});

Console.WriteLine($"From NSwagMSBuildSample");
var weathers1 = await client1.GetWeatherForecastAsync();

foreach (var weather in weathers1)
{
    Console.WriteLine($"{weather.Date}\t{weather.TemperatureC}°C\t{weather.TemperatureF}°F\t{weather.Summary}");
}

Console.WriteLine($"\nFrom WebApi2");
var weathers2 = await client2.GetWeatherForecastAsync();

foreach (var weather in weathers2)
{
    Console.WriteLine($"{weather.Date}\t{weather.TemperatureC}°C\t{weather.TemperatureF}°F\t{weather.Summary}");
}
Console.ReadKey();
