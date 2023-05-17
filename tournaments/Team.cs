public class Team
{
    List<Player> _players = new List<Player>();
    string _name;
    int _wins = 0;
    int _losses = 0;

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _players.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"Team {_name}");
        Console.WriteLine($"Wins: {_wins}");
        Console.WriteLine($"Losses: {_losses}");
        foreach(Player player in _players)
        {
            Console.WriteLine(player.DisplayPlayer());
        }
    }

    public void AddWin(int num = 1)
    {
        _wins += num;
    }

    public void AddLoss(int num = 1)
    {
        _losses += num;
    }
}