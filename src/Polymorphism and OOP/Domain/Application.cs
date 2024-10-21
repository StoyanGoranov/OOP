using Toni.Messages.Infrastructure;
using Toni.Messages.Infrastructure.Implementations;

namespace Toni.Messages.Domain;

public class Application
{
    private const string CompanyName = "NotACompany";
    ISerializer _serializer = new Serializer();
    IMessageSender _sender = new MessageSender();

    public List<IMessageFormatter> _messages { get; set; } = new List<IMessageFormatter>();

    public void AddMessages(params IMessageFormatter[] messages) 
    {  
        _messages.AddRange(messages); 
    }

    public void Send(string occasion)
    {
        foreach(var message in _messages)
        {
            message.FormatMessage([CompanyName,occasion]);
        }
        _sender.Send(_messages);
    }
}

