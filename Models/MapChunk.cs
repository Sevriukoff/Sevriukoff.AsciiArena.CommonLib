namespace Sevriukoff.AsciiArena.CommonLib;

public class MapChunk
{
    public int StartX { get; set; }
    public int StartY { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    
    public List<List<string>> Cells { get; set; } = [];
}