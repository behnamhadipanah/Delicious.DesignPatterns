public class EmailNotification : AbstractRegisterOrder
{
    protected override void SendNotificationForUser()
    {
        Console.WriteLine("Send Notification as a email");
    }
}