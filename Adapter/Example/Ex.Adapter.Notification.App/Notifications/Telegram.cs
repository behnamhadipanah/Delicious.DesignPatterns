using Ex.Adapter.Notification.App.Notifications;

public class Telegram : ISendMessage
{
    public void Send(string message)
    {
       
        Console.WriteLine(message);
        Console.WriteLine($"Send message with {nameof(Telegram)} class .");
    }
}