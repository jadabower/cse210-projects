public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected bool _isCompleted;
    protected int _pointsOnCompletion;
    protected int _points;

    public Goal(string name, string description, bool isCompleted, int pointsOnCompletion, int points)
    {
        _name = name;
        _description = description;
        _isCompleted = isCompleted;
        _pointsOnCompletion = pointsOnCompletion;
        _points = points;
    }
    public Goal()
    {
        _name = GetName();
        _description = GetDescription();
        _isCompleted = false;
        _pointsOnCompletion = GetPointsOnCompletion();
        _points = 0;

    }

    public virtual void CompleteGoal()
    {
        _isCompleted = true;
        _points += _pointsOnCompletion;
    }

    public string GetName()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        return name;
    }

    public string GetDescription()
    {
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        return description;
    }

    public int GetPointsOnCompletion()
    {
        bool canConvert = false;
        while (!canConvert)
        {
            Console.Write("How many points should this goal be worth on completion (please enter an integer)? ");
            string pointsAsString = Console.ReadLine();
            canConvert = int.TryParse(pointsAsString, out int pointsAsInt);
            if (canConvert)
            {
                return pointsAsInt;
            }
        }
        return 0;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void DisplayGoal();

    public abstract string ConvertToSaveString();
}