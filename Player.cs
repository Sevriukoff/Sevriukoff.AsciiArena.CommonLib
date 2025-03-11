namespace Sevriukoff.AsciiArena.CommonLib;

public class Player
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public double Health { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    
    public Player(Guid id, string userName, double health, int x, int y)
    {
        Id = id;
        Health = health;
        X = x;
        Y = y;
        UserName = userName;
    }
}