public class Lecture : Event
{
    string _speaker;
    int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return ($"{_title} - Lecture\n{_description}\nSpeaker: {_speaker}\nMaximum Capacity: {_capacity}\n{_time}, {_date}\n{_address.Stringify()}");
    }
    public override string GetShortDescription()
    {
        return ($"{_title} - Lecture\n{_date}");
    }
}