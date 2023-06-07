public class Activity 
{
    private string _name;
    private string _description;
    private int _duration = 30;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetNewDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = Console.Read();
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void DisplayPauseAnimation()
    {
        Console.WriteLine();
        for (int i = 0; i < 2; i++)
        {
            Console.Write("\b \b|");
            Thread.Sleep(400);
            Console.Write("\b \b/");
            Thread.Sleep(400);
            Console.Write("\b \b—");
            Thread.Sleep(400);
            Console.Write("\b \b\\");
            Thread.Sleep(400);
            Console.Write("\b \b");
            if (i > 0)
            {
                Console.Write("\b \b|");
                Thread.Sleep(400);
                Console.Write("\b \b");
            }
        }
    }
}