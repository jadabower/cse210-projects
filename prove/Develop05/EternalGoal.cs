public class EternalGoal : Goal
{
    int _timesCompleted;

    public EternalGoal(string name, string description, bool isCompleted, int pointsOnCompletion, int points, int timesCompleted) : base(name, description, isCompleted, pointsOnCompletion, points)
    {
        _timesCompleted = timesCompleted;
    }
    public EternalGoal() : base()
    {
        _timesCompleted = 0;
    }

    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        base.CompleteGoal();
    }

    public override void DisplayGoal()
    {
        string checkbox = $"[{_timesCompleted} time(s) completed]";
        Console.WriteLine($"{checkbox} {_name} ({_description}) (worth {_pointsOnCompletion} points on each instance)");
    }

    public override string ConvertToSaveString()
    {
        return $"eternal|||{_name}|||{_description}|||{_isCompleted}|||{_pointsOnCompletion}|||{_points}|||{_timesCompleted}";
    }
}