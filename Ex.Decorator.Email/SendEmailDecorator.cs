namespace Ex.Decorator.Email;

public class SendEmailDecorator:SendEmail
{
    private readonly SendEmail _sendEmail;

    public SendEmailDecorator(SendEmail sendEmail)
    {
        _sendEmail = sendEmail;
    }

    public void Send()
    {
        _sendEmail.Send();
        SaveLog();
    }

    private void SaveLog()
    {
        Console.WriteLine("Save Log.......");

    }
}