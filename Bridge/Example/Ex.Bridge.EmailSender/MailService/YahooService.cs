using Ex.Bridge.EmailSender.MailService.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Bridge.EmailSender.MailService
{
    public class YahooService : IMailServiceBridge
    {
        public List<string> GetEmails()
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string reciver, string title, string meesage)
        {
            // Code Send Yahoo

            Console.WriteLine($"Email {title} Sended to {reciver} With {nameof(YahooService)}");
        }
    }
}
