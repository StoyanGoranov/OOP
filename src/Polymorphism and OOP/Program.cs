
using Toni.Messages.Domain;
using Toni.Messages.Infrastructure;
using Toni.Messages.Infrastructure.Implementations;

var serializer = new Serializer();
var receiver = new MessageReceiver(serializer);

var staticMessageJson = "THis is a static message";
var json2 = $"THis is a dynamic message from company {{0}}";
var json3 = $"Congratulations on {{0}} from {{1}}";   

var messages = new List<IMessageFormatter>();
messages.Add(new Signal() { Message= staticMessageJson});
messages.Add(new Signal() { Message = json2 });
messages.Add(new Signal() { Message = json3 });
messages.Add(new ReverseTelegram() { Message = json3 });

receiver.Receive(messages);

var occasion = Console.ReadLine();
receiver.Submit(occasion);
public abstract class Telegram : IMessageFormatter
{
    public string Message { get; set; }
    public string GetMessage()
    {
        return Message;
    }
    public abstract void FormatMessage(string[] args);
}

public class Signal : Telegram
{
    public override void FormatMessage(string[] args)
    {
        Message = String.Format(Message, args);
    }
}

public class ReverseTelegram : Telegram
{
    public override void FormatMessage(string[] args) 
    {
        Message = String.Format(Message, args.Reverse().ToArray());
    }
}