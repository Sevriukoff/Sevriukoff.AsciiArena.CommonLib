namespace Sevriukoff.AsciiArena.CommonLib;

public class LoginResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = "";
    public Player? Player { get; set; }
    public Cell[][]? MapData { get; set; }
    
    public int StartX { get; set; }
    public int StartY { get; set; }
}