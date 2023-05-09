public class Prompt
{
    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        // create prompts and add them to the _prompts list
        _prompts.Add("What brought you joy today?");
        _prompts.Add("When did you feel happiest today?");
        _prompts.Add("What was your favorite place that you went to today?");
        _prompts.Add("What is something that made you laugh today?");
        _prompts.Add("Who made your day better today?");
        _prompts.Add("What steps did you take toward a goal you're working on?");
        _prompts.Add("What made today unique?");
        _prompts.Add("How did you see the hand of the Lord in you life today?");
        _prompts.Add("Describe your day in 5 words or less.");
        _prompts.Add("When did you feel most authentically yourself today?");
        _prompts.Add("How can you make tomorrow (even) better than today?");
        _prompts.Add("What are three things you are grateful for today?");
        _prompts.Add("If you had one thing you could do over today, what would it be?");
    }

    public int GetRandomNumber()
    {
        // get a random number within the length of the list
        var Random = new Random();
        var randomNumber = Random.Next(0, (_prompts.Count() - 1));
        return randomNumber;
    }
    
    public string GetRandomPrompt(int randNum)
    {
        // choose a prompt from the _prompts list at the randNum, and return it.
        // also call the method to move the chosen prompt to the _usedPrompts.
        string prompt = _prompts[randNum];
        MoveToUsed(randNum);
        return prompt;
    }


    public void MoveToUsed(int index)
    {
        // move the chosen prompt to the used list
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        _usedPrompts.Add(prompt);
    }

    public bool CheckForPrompts()
    {
        // check the length of the _prompts list and return true if there are still prompts left
        return (_prompts.Count() > 0);
    }

    public void ShufflePrompts()
    {
        // move from _usedPrompts to _prompts
        foreach (string prompt in _usedPrompts)
        {
            _usedPrompts.Remove(prompt);
            _prompts.Add(prompt);
        }
    }
    public string ReturnRandPrompt()
    {
        if (CheckForPrompts() == false)
        {
            ShufflePrompts();
        }
        int index = GetRandomNumber();
        string rPrompt = GetRandomPrompt(index);
        return rPrompt;
    }
}