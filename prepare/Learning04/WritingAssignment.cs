public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string sName, string topic) : base(sName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}