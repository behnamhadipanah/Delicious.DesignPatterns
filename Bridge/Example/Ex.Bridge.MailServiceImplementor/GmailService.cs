using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Bridge.MailServiceImplementor
{
    public class GmailService:IMailServiceBridge
    {
        public List<string> GetEmails()
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string reciver, string title, string meesage)
        {
            // Code Send Gmail

            Console.WriteLine($"Email {title} Sended to {reciver} With {nameof(GmailService)}");
        }
    }
}
