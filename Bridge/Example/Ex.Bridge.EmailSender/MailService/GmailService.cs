using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex.Bridge.EmailSender.MailService.Bridge;

namespace Ex.Bridge.EmailSender.MailService
{
    public class GmailService:IMailServiceBridge
    {
        public void SendEmail(string reciver, string title, string meesage)
        {
            // Code Send Gmail

            Console.WriteLine($"Email {title} Sended to {reciver} With {nameof(GmailService)}");
        }
    }
}
