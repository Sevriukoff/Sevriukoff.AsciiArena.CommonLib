namespace Sevriukoff.AsciiArena.CommonLib;

public class GameState
{
    public int StartX { get; set; }
    public int StartY { get; set; }
    
    public Map Map { get; set; }
    public List<Player> Players { get; set; }
}