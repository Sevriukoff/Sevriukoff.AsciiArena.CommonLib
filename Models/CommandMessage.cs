using System.Text.Json.Serialization;

namespace Sevriukoff.AsciiArena.CommonLib;

[JsonConverter(typeof(CommandMessageJsonConverter))]
public abstract class CommandMessage
{
    public abstract CommandType Command { get; }
}