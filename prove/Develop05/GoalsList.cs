using System.IO;
public class GoalsList
{
    List<Goal> _goalsList = new List<Goal>();
    string _filename;

    public GoalsList(string filename)
    {
        _filename = filename;
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|||");
                string goalType = parts[0];
                if (goalType == "checklist")
                {
                    string name = parts[1];
                    string description = parts[2];
                    bool isCompleted = Convert.ToBoolean(parts[3]);
                    int pointsOnCompletion = Convert.ToInt32(parts[4]);
                    int points = Convert.ToInt32(parts[5]);
                    int timesCompleted = Convert.ToInt32(parts[6]);
                    int timesRequiredForCompletion = Convert.ToInt32(parts[7]);
                    int pointsOnInstance = Convert.ToInt32(parts[8]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, isCompleted, pointsOnCompletion, points, timesCompleted, timesRequiredForCompletion, pointsOnInstance);
                    _goalsList.Add(goal);
                }
                else if (goalType == "eternal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    bool isCompleted = Convert.ToBoolean(parts[3]);
                    int pointsOnCompletion = Convert.ToInt32(parts[4]);
                    int points = Convert.ToInt32(parts[5]);
                    int timesCompleted = Convert.ToInt32(parts[6]);

                    EternalGoal goal = new EternalGoal(name, description, isCompleted, pointsOnCompletion, points, timesCompleted);
                    _goalsList.Add(goal);
                }
                else // if it's simple
                {
                    string name = parts[1];
                    string description = parts[2];
                    bool isCompleted = Convert.ToBoolean(parts[3]);
                    int pointsOnCompletion = Convert.ToInt32(parts[4]);
                    int points = Convert.ToInt32(parts[5]);

                    SimpleGoal goal = new SimpleGoal(name, description, isCompleted, pointsOnCompletion, points);
                    _goalsList.Add(goal);
                }
            }
        }
        else
        {
            string path = $@"C:\Users\jadab\Downloads\Jada personal\Programming with Classes\cse210-projects\prove\Develop05\{_filename}";
            using (FileStream fs = File.Create(path)){}
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(@_filename))
        {
            foreach (Goal goal in _goalsList)
            {
                outputFile.WriteLine(goal.ConvertToSaveString());
            }
        }
    }

    public void DisplayTotalPoints()
    {
        int totalPoints = 0;
        foreach (Goal goal in _goalsList)
        {
            totalPoints += goal.GetPoints();
        }
        Console.WriteLine($"Total points you've earned for these goals: {totalPoints}\n");
    }

    public void DisplayList()
    {
        DisplayTotalPoints();
        Console.WriteLine("Goals:");
        for(int i = 1; i < _goalsList.Count + 1; i++)
        {
            Console.Write($"{i}. ");
            _goalsList[i-1].DisplayGoal();
        }
        Console.WriteLine();
    }

    public void AddGoal()
    {
        Console.Write("What kind of goal would you like to create (checklist, eternal, or simple -- default is simple)? ");
        string goalType = Console.ReadLine() ?? String.Empty;
        if (goalType.ToLower() == "checklist")
        {
            ChecklistGoal goal = new ChecklistGoal();
            _goalsList.Add(goal);
        }
        else if (goalType.ToLower() == "eternal")
        {
            EternalGoal goal = new EternalGoal();
            _goalsList.Add(goal);
        }
        else
        {
            SimpleGoal goal = new SimpleGoal();
            _goalsList.Add(goal);
        }
    }

    public void RecordEvent()
    {
        DisplayList();
        bool canConvert = false;
        while (!canConvert)
        {
            Console.Write("Which goal would you like to record (please enter an integer)? ");
            string goalNumberAsString = Console.ReadLine();
            canConvert = int.TryParse(goalNumberAsString, out int goalNumber);
            if (canConvert)
            {
                int goalIndex = goalNumber - 1;
                _goalsList[goalIndex].CompleteGoal();
            }
        }
    }
}