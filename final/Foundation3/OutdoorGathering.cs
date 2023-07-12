public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public string WeatherForecast
    {
        get { return _weatherForecast; }
        set { _weatherForecast = value; }
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
