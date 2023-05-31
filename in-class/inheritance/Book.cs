public class Book : Loanable
{
    private string _isbn;
    private string _upc;

    public Book(string title, string isbn, string upc) : base(title)
    {
        _isbn = isbn;
        _upc = upc;
    }

    public void ShowBookDetails()
    {
        base.Display();
        Console.WriteLine($"ISBN: {_isbn}\nUPC: {_upc}");
    }
}