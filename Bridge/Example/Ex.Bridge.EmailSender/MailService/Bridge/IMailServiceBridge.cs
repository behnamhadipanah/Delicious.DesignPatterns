using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Bridge.EmailSender.MailService.Bridge
{
    //MailServiceImplementor
    public interface IMailServiceBridge
    {
        void SendEmail(string receiver,string title,string message);
        List<string> GetEmails();
    }
}
