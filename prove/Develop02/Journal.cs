public class Journal
{
    List<Entry> _entries = new List<Entry>();
    Prompt _prompts = new Prompt();
    string _filename;


    public Journal(string filename)
    {
        _filename = filename;
    }

    public void NewEntry()
    {
        // creates a new entry and adds it to the list of entries
        _entries.Add(new Entry(_prompts));
    }

    public void DisplayJournal()
    {
        // displays each journal entry saved in the file
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void SaveJournal()
    {
        // saves each journal entry in _entries to the journal
        foreach (Entry entry in _entries)
        {
            entry.SaveEntryToJournal(_filename);
        }
        _entries.Clear();
    }
}