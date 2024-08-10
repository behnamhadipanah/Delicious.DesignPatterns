using Ex.Adapter.Notification.App.Notifications;

public class WhatsApp : ISendMessage
{
    public void Send(string message)
    {

        Console.WriteLine(message);
        Console.WriteLine($"Send message with {nameof(WhatsApp)} class .");
    }
}