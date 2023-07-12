public class Swimming:Activity
{
    double _laps;
    
    public Swimming(string date, int length, double laps) : base(date, length)
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
}