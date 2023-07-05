public class OutdoorGathering : Event
{
    string _weatherForecast;

    public OutdoorGathering(string weatherForecast, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public override string GetFullDetails()
    {
        return ($"{_title} - Outdoor Gathering\n{_description}\nWeather Forecast: {_weatherForecast}\n{_time}, {_date}\n{_address.Stringify()}");
    }
    public override string GetShortDescription()
    {
        return ($"{_title} - Outdoor Gathering\n{_date}");
    }
}