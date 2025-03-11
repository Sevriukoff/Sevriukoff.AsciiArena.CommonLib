namespace Sevriukoff.AsciiArena.CommonLib;

public class LoginCommandMessage : CommandMessage
{
    public override CommandType Command => CommandType.Login;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class ChunkCommandMessage: CommandMessage
{
    public override CommandType Command => CommandType.Chunk;
    
    public Guid PlayerId { get; set; }
    public int PlayerX { get; set; }
    public int PlayerY { get; set; }
}