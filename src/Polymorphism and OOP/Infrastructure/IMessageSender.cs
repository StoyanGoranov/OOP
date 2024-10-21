using Toni.Messages.Domain;

namespace Toni.Messages.Infrastructure;

public interface IMessageSender
{
    void Send(IEnumerable<IMessageFormatter> messages);
}


