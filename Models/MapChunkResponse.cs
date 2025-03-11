namespace Sevriukoff.AsciiArena.CommonLib;

public class MapChunkResponse
{
    public int StartX { get; set; }
    public int StartY { get; set; }
    public Cell[][] Cells { get; set; }
}