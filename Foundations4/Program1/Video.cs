public class Video
{
    string _title;
    string _author;
    int _lengthInSeconds;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author} | {_lengthInSeconds} seconds");
        Console.WriteLine($"{GetNumberOfComments()} comments:");
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}