public class Book
{
    private string _author;
    private string _name;
    private int _timesread = 0;
    private bool _available = false;    

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
    }

    public bool IsAvailable()
    {
        if(!_available)
        {
            Console.WriteLine("Checked out");
        }
        return _available;
    }
}
