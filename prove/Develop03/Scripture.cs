public class Scripture
{
    Reference _reference;
    List<Word> _originalText = new List<Word>(); 
    List<int> _indexOfWordsToBlankOut = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        this.InitializeOriginalText(text);
    }


    public void BlankNextRandomWords()
    {
        List<int> indexesNotBlank = new List<int>();
        for (int i = 0; i < _originalText.Count(); i++)
        {
            if (!_indexOfWordsToBlankOut.Contains(i))
            {
                indexesNotBlank.Add(i);
            }
        }
        for (int i = 0; i < Math.Min(3, indexesNotBlank.Count()); i++)
        {
            var Random = new Random(); 
            var randomIndexOfIndexesNotBlank = Random.Next(0, indexesNotBlank.Count());
            _indexOfWordsToBlankOut.Add(indexesNotBlank[randomIndexOfIndexesNotBlank]);
            indexesNotBlank.RemoveAt(randomIndexOfIndexesNotBlank);
        }
    }

    public bool IsWholeVerseBlank()
    {
        return _indexOfWordsToBlankOut.Count() == _originalText.Count();
    }

    private void InitializeOriginalText(string text)
    {
        String[] textString = text.Split(" ");
        foreach (string substring in textString)
        {
            Word word = new Word(substring);
            _originalText.Add(word);
        }
    }

    private List<string> GenerateVariableText()
    {
        List<string> variableText = new List<string>();
        for (int i = 0; i <  _originalText.Count(); i++)
        {
            if (_indexOfWordsToBlankOut.Contains(i))
            {
                variableText.Add(_originalText[i].GetBlankString());
            }
            else
            {
                variableText.Add(_originalText[i].GetString());
            }
        }
        return variableText;
    }

    public string GetScripture()
    {
        string stringText = $"{_reference.GetReference()} ";
        foreach (Word word in _originalText)
        {
            stringText += $"{word.GetString()} ";
        }
        return stringText;
    }

    public string GetScriptureWithBlanks()
    {
        string stringText = $"{_reference.GetReference()} ";
        List<string> variableText = this.GenerateVariableText();
        foreach (string word in variableText)
        {
            stringText += $"{word} ";
        }

        return stringText;
    }
}