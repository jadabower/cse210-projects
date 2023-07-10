public class Running:Activity
{
    double _distance;
    
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    protected override double GetDistance()
    {
        return _distance;
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