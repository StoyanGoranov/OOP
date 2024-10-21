using System.Text.Json;
using Toni.Messages.Domain;

namespace Toni.Messages.Infrastructure.Implementations;

public class Serializer : ISerializer
{
    public IEnumerable<Telegram> Deserialize(string json)
    {
        var objects = JsonSerializer.Deserialize<Telegram[]>(json) ?? [];
        return objects;
    }

    public string Serialize(IEnumerable<Telegram> obj)
    {
        var json = JsonSerializer.Serialize(obj);
        return json;
    }
}
