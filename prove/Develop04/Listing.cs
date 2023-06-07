public class Listing : Activity
{
    private TimeOnly _startTime;
    private TimeOnly _endTime;
    private string _prompt = "";
    private int _responseNum = 0;
    private List<string> _prompts = new List<string>();
    // private List<string> _responses = new List<string>();

    public Listing(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        DisplayStartMessage();
        SetNewDuration();
    }

    public void DisplayListingActivity()
    {
        _prompt = PickRandomFromList(_prompts);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.Write($"---{_prompt}---");
        DisplayPauseAnimation(7);

        _startTime = TimeOnly.FromDateTime(DateTime.Now);
        _endTime = _startTime.Add(TimeSpan.FromSeconds(_duration));

        while (true)
        {
            if ((TimeOnly.FromDateTime(DateTime.Now)) > _endTime)
            {
                break;
            }
            else
            {
                string response = "";
                while (response == "")
                {
                    Console.Write("> ");
                    response = Console.ReadLine() ?? String.Empty;
                    // _responses.Add(response);
                    _responseNum += 1;
                }
            }
        }
    
        DisplayNumOfResponses();
        DisplayEndMessage();
    }

    private void DisplayNumOfResponses()
    {
        Console.WriteLine($"You listed {_responseNum} items!");
        DisplayPauseAnimation();
    }
}