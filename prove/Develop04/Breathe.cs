public class Breathe : Activity
{
    private int _breathRotations;

    public Breathe(string name, string description) : base(name, description)
    {
        DisplayStartMessage();
        SetNewDuration();
        _breathRotations = (int)(_duration / 10);
        _restTime = _duration % 10;
    }

    public void DisplayBreatheActivity()
    {
        for (int i = 0; i < _breathRotations; i++)
        {
            Console.WriteLine();
            DisplayBreatheIn();
            DisplayBreatheOut();
        }

        DisplayEndMessage();
    }

    private void DisplayBreatheIn()
    {
        Console.WriteLine();
        Console.Write("Breathe in... ");
        Console.Write(".");
        Thread.Sleep(1333);
        Console.Write("\b \bo");
        Thread.Sleep(1334);
        Console.Write("\b \bO");
        Thread.Sleep(1333);
        Console.Write("\b \b");
        // Breathe in... .oO
    }

    private void DisplayBreatheOut()
    {
        Console.WriteLine();
        Console.Write("Breathe out... ");
        Console.Write("O");
        Thread.Sleep(2000);
        Console.Write("\b \bo");
        Thread.Sleep(2000);
        Console.Write("\b \b.");
        Thread.Sleep(2000);
        Console.Write("\b \b");
        // Breathe out... Oo.
    }
}