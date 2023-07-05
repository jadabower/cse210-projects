public class Reception : Event
{
    string _email;  

    public Reception(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public override string GetFullDetails()
    {
        return ($"{_title} - Reception\n{_description}\nRSVP Email: {_email}\n{_time}, {_date}\n{_address.Stringify()}");
    }
    public override string GetShortDescription()
    {
        return ($"{_title} - Reception\n{_date}");
    }
}