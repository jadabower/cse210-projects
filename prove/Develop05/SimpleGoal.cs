public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, bool isCompleted, int pointsOnCompletion, int points) : base(name, description, isCompleted, pointsOnCompletion, points){}
    public SimpleGoal() : base(){}

    public override void DisplayGoal()
    {
        string checkbox = (_isCompleted == true) ? "[X]" : "[ ]";
        Console.WriteLine($"{checkbox} {_name} ({_description}) (worth {_pointsOnCompletion} points on completion)");
    }

    public override string ConvertToSaveString()
    {
        return $"simple|||{_name}|||{_description}|||{_isCompleted}|||{_pointsOnCompletion}|||{_points}";
    }
}