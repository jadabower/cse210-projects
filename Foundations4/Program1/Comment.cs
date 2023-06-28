public class Comment
{
    string _commenter;
    string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"\"{_text}\" -{_commenter}");
    }
}