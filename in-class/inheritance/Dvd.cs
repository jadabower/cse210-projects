public class Dvd : Loanable
{
    private string _runtime;
    private string _rating;
    public Dvd(string title, string runtime, string rating) : base(title)
    {
        _runtime = runtime;
        _rating = rating;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Runtime: {_runtime}\nRating: {_rating}");
    }
}