public class Entry
{
    string _prompt;
    string _text;
    string _location;
    string _emotion;
    string _dateAndTime;

    public Entry(Prompt prompts)
    {
        // constructor that calls the other functions to create all the attributes.
        _prompt = prompts.ReturnRandPrompt();
        _text = GetResponseFromUser(_prompt);
        _emotion = GetResponseFromUser("What was the overall emotion/vibe of the day?");
        _location = GetResponseFromUser("Where are you writing this from?");
        _dateAndTime = GetDateTime();
    }

    public string GetResponseFromUser(string prompt)
    {
        // presents the user with a prompt and returns their response
        Console.WriteLine(prompt);
        string response = Console.ReadLine() ?? String.Empty;
        return response;
    }

    public string SaveEntryToJournal(Entry entry)
    {
        // saves the entry to the journal file
        return ($"{entry._dateAndTime} | {entry._location} | Prompt: {entry._prompt} \n{entry._text}\n Emotion/Vibe of the day: \n{entry._emotion}\n");
    }

    public void DisplayEntry()
    {
        // prints out the entry nicely
        Console.WriteLine($"{_dateAndTime} | {_location} | Prompt: {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine($"Emotion/Vibe of the day:");
        Console.WriteLine($"{_emotion}\n");
    }

    public string GetDateTime()
    {
        // gets the current date and time and formats it into a string
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm tt");
        return formattedDateTime;
    }
}