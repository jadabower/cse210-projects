public class Word
{
    string _word;

    public Word(string word)
    {
        _word = word;
    }

    public string GetString()
    {
        return _word;
    }
    public string GetBlankString()
    {
        string underscores = "";
        foreach(char letter in _word)
        {
            underscores += "_";
        }
        return underscores;
    }
}