public class Reflect : Activity
{
    private int _questionRotations;
    private string _prompt = "";
    private string _question = "";
    private List<string> _prompts = new List<string>();
    private List<string> _unusedQuestions = new List<string>();
    private List<string> _usedQuestions = new List<string>();

    public Reflect(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _unusedQuestions.Add("Why was this experience meaningful to you?");
        _unusedQuestions.Add("Have you ever done anything like this before?");
        _unusedQuestions.Add("How did you get started?");
        _unusedQuestions.Add("How did you feel when it was complete?");
        _unusedQuestions.Add("What made this time different than other times when you were not as successful?");
        _unusedQuestions.Add("What is your favorite thing about this experience?");
        _unusedQuestions.Add("What could you learn from this experience that applies to other situations?");
        _unusedQuestions.Add("What did you learn about yourself through this experience?");
        _unusedQuestions.Add("How can you keep this experience in mind in the future?");

        DisplayStartMessage();
        SetNewDuration();
        _questionRotations = (int)(_duration / 7);
        _restTime = _duration % 7;
    }

    public void DisplayReflectActivity()
    {
        _prompt = PickRandomFromList(_prompts);
        Console.WriteLine("Consider the following prompt: ");
        Console.Write($"---{_prompt}---");
        DisplayPauseAnimation(10.4);
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        DisplayPauseAnimation();

        for (int i = 0; i < (_questionRotations - 2); i++)
        {
            if (CheckIfEmpty())
            {
                ShuffleQuestions();
            }
            
            Console.Clear();

            _question = PickRandomFromList(_unusedQuestions);
            _unusedQuestions.Remove(_question);
            _usedQuestions.Add(_question);

            Console.WriteLine();
            Console.Write(_question);
            DisplayPauseAnimation(7);
        }

        DisplayEndMessage();
    }

    private bool CheckIfEmpty()
    {
        if (_unusedQuestions.Count() > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void ShuffleQuestions()
    {
        foreach(string question in _usedQuestions)
        {
            _usedQuestions.Remove(question);
            _unusedQuestions.Add(question);
        }
    }

}