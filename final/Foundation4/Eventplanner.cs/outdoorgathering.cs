using System.Net.Http;

public class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public override string GetFullDetails()
    {
        // Fetching weather data from an API (replace 'API_KEY' with a valid key)
        string apiKey = "API_KEY";
        using (HttpClient client = new HttpClient())
        {
            string cityState = $"{Address.City},{Address.State}";
            string weatherData = client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityState}&appid={apiKey}").Result;
            string weatherDescription = weatherData.Split("\"description\":\"")[1].Split("\",")[0];
            return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherDescription}";
        }
    }
}