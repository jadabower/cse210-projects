public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>(); 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        this.InitializeOriginalText(text);
    }

    public bool HideRandomWord()
    {
        var Random = new Random();
        while (true)
        {
            var randomIndex = Random.Next(0, (_words.Count()));
            if ((_words[randomIndex]).CheckIfShown())
            {
                (_words[randomIndex]).HideWord();
                break;
            }
        }
        return true;
    }

    public bool CheckIfWordsRemaining()
    {
        List<bool> blankOrNot = new List<bool>();
        foreach (Word word in _words)
        {
            blankOrNot.Add(word.CheckIfShown());
        }
        bool containsTrue = blankOrNot.Contains(true);
        return containsTrue;
    }

    private void InitializeOriginalText(string text)
    {
        String[] textString = text.Split(" ");
        foreach (string substring in textString)
        {
            Word word = new Word(substring);
            _words.Add(word);
        }
    }

    public string GetScripture()
    {
        string stringText = $"{_reference.GetReference()} ";
        foreach (Word word in _words)
        {
            stringText += $"{word.GetWordAsString()} ";
        }
        return stringText;
    }
}