public abstract class Activity
{
    protected string _date;
    protected int _lengthInMinutes;

    protected Activity(string date, int length)
    {
        _date = date;
        _lengthInMinutes = length;
    }
    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_lengthInMinutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}