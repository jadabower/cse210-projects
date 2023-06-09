public class Cycling:Activity
{
    double _speed;
    
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        return _speed * _lengthInMinutes;
    }
    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override double GetPace()
    {
        return (_lengthInMinutes / GetDistance());
    }
}