namespace Sevriukoff.AsciiArena.CommonLib;

public class RegisterCommandMessage : CommandMessage
{
    public override CommandType Command => CommandType.Register;
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
}