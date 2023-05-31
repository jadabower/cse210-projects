public class Loanable
{
    private bool _isCheckedIn = true;
    private string _title;

    public Loanable(string title)
    {
        _title = title;
    }

    public void CheckOut()
    {
        _isCheckedIn = false;
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Title: {_title}\nAvailable: {_isCheckedIn}");
    }
}