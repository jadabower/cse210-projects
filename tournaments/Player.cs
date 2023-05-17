public class Player
{
    string _name;
    string _position = "";
    int _jerseyNumber;

    public Player(string name, int jersey)
    {
        _name = name;
        _jerseyNumber = jersey;
    }
    public Player(string name, int jersey, string position)
    {
        _name = name;
        _jerseyNumber = jersey;
        _position = position;
    }

    public void SetPosition(string position)
    {
        _position = position;
    }
    public string DisplayPlayer()
    {
        _position = (_position != "") ? $"{_position} " : _position;
        return $"{_name}: {_position}{_jerseyNumber}";
    }
}