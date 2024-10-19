public class SmsNotification : AbstractRegisterOrder
{
    protected override void SendNotificationForUser()
    {
        Console.WriteLine("Send Notification as a SMS");
    }
}