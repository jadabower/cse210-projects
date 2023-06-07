public class Activity 
{
    private string _name;
    private string _description;
    protected int _duration = 0;
    protected double _restTime = 0;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string PickRandomFromList(List<string> list)
    {
        var random = new Random();
        var randIndex = random.Next(list.Count());
        return list[randIndex];
    }

    public void SetNewDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayPauseAnimation();
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        DisplayPauseAnimation(_restTime);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        DisplayPauseAnimation();
        Console.Clear();
    }

    public void DisplayPauseAnimation(double restTime = 3.6)
    {
        int restDuration = (int)((restTime * 1000) / 9);
        Console.WriteLine();
        for (int i = 0; i < 2; i++)
        {
            Console.Write("\b \b|");
            Thread.Sleep(restDuration);
            Console.Write("\b \b/");
            Thread.Sleep(restDuration);
            Console.Write("\b \b—");
            Thread.Sleep(restDuration);
            Console.Write("\b \b\\");
            Thread.Sleep(restDuration);
            Console.Write("\b \b");
            if (i > 0)
            {
                Console.Write("\b \b|");
                Thread.Sleep(restDuration);
                Console.Write("\b \b");
            }
        }
    }
}