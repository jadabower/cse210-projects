public class ChecklistGoal : Goal
{
    int _timesCompleted;
    int _timesRequiredForCompletion;
    int _pointsOnInstance;

    public ChecklistGoal(string name, string description, bool isCompleted, int pointsOnCompletion, int points, int timesCompleted, int timesRequiredForCompletion, int pointsOnInstance) : base(name, description, isCompleted, pointsOnCompletion, points)
    {
        _timesCompleted = timesCompleted;
        _timesRequiredForCompletion = timesRequiredForCompletion;
        _pointsOnInstance = pointsOnInstance;
    }
    public ChecklistGoal() : base()
    {
        _timesCompleted = 0;
        _timesRequiredForCompletion = GetTimesRequired();
        _pointsOnInstance = GetPointsOnInstance();
    }

    public int GetTimesRequired()
    {
        bool canConvert = false;
        while (!canConvert)
        {
            Console.Write("How many times should you do this goal before it's completed (please enter an integer)? ");
            string requiredAsString = Console.ReadLine();
            canConvert = int.TryParse(requiredAsString, out int requiredAsInt);
            if (canConvert)
            {
                return requiredAsInt;
            }
        }
        return 0;
    }

    public int GetPointsOnInstance()
    {
        bool canConvert = false;
        while (!canConvert)
        {
            Console.Write("How many points should this goal be worth every time you do it (please enter an integer)? ");
            string pointsAsString = Console.ReadLine();
            canConvert = int.TryParse(pointsAsString, out int pointsAsInt);
            if (canConvert)
            {
                return pointsAsInt;
            }
        }
        return 0;
    }

    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        _points += _pointsOnInstance;
        if (_timesCompleted == _timesRequiredForCompletion)
        {
            base.CompleteGoal();
        }
    }

    public override void DisplayGoal()
    {
        string checkbox = (_isCompleted == true) ? "[X]" : "[ ]";
        Console.WriteLine($"{checkbox} {_name} ({_description}) (worth {_pointsOnInstance} points on each instance and {_pointsOnCompletion} points on completion) -- {_timesCompleted}/{_timesRequiredForCompletion} times completed");
    }

    public override string ConvertToSaveString()
    {
        return $"checklist|||{_name}|||{_description}|||{_isCompleted}|||{_pointsOnCompletion}|||{_points}|||{_timesCompleted}|||{_timesRequiredForCompletion}|||{_pointsOnInstance}";
    }
}