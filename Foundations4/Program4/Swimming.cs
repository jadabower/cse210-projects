public class Swimming:Activity
{
    int _laps;
    string _type = "Swimming";
    
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    protected override double GetDistance()
    {
        return (((_laps * 50) / 1000) * 0.62);
    }
    protected override double GetSpeed()
    {
        return ((GetDistance() / _lengthInMinutes) * 60);
    }
    protected override double GetPace()
    {
        return (_lengthInMinutes / GetDistance());
    }
    protected override string GetActivityType()
    {
        return _type;
    }
}