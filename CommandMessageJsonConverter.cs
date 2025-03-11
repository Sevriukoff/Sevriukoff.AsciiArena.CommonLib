using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sevriukoff.AsciiArena.CommonLib;

public class CommandMessageJsonConverter : JsonConverter<CommandMessage>
{
    public override CommandMessage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        
        if (!document.RootElement.TryGetProperty("Command", out var commandElement))
            throw new JsonException("Missing Command property");
        
        var commandString = commandElement.GetInt32();

        var commandEnum = (CommandType)commandString;

        CommandMessage? result = commandEnum switch
        {
            CommandType.Login => document.RootElement.Deserialize<LoginCommandMessage>(options),
            CommandType.Register => document.RootElement.Deserialize<RegisterCommandMessage>(options),
            CommandType.Move => document.RootElement.Deserialize<MoveCommandMessage>(options),
            CommandType.Chunk => document.RootElement.Deserialize<ChunkCommandMessage>(options),
            _ => throw new JsonException($"Unknown command type: {commandString}")
        };

        return result;
    }

    public override void Write(Utf8JsonWriter writer, CommandMessage value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
    }
}