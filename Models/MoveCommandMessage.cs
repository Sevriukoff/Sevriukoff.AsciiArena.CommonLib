namespace Sevriukoff.AsciiArena.CommonLib;

public class MoveCommandMessage : CommandMessage
{
    public override CommandType Command => CommandType.Move;
    public Direction Direction { get; set; }
}