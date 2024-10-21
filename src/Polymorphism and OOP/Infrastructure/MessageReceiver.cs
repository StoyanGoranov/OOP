using Toni.Messages.Domain;

namespace Toni.Messages.Infrastructure;

public class MessageReceiver
{
    ISerializer _serializer;

    private Application Application = new Application();
    public MessageReceiver(ISerializer serializer)
    {
        _serializer = serializer;
    }

    public void Receive(IEnumerable<IMessageFormatter> messages)
    {
        Application.AddMessages(messages.ToArray());
    }

    public void Submit(string occasion)
    {
        Application.Send(occasion);
        // TODO: send all contained messages
    }
}
