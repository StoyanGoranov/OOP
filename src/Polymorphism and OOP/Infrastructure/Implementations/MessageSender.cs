using Toni.Messages.Domain;

namespace Toni.Messages.Infrastructure.Implementations;

public class MessageSender : IMessageSender
{
    public void Send(IEnumerable<IMessageFormatter> messages)
    {
        Console.WriteLine("Sending messages:");
        foreach (var message in messages)
        {
            Console.WriteLine(message.GetMessage());
        }
    }
}
