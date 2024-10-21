using Toni.Messages.Domain;

namespace Toni.Messages.Infrastructure;
public interface ISerializer
{
    // TODO: replace object with domain class
    IEnumerable<Telegram> Deserialize(string json);
    string Serialize(IEnumerable<Telegram> obj);
}
