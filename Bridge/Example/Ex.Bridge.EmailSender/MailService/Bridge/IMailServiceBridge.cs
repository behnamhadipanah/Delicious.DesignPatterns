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
        void SendEmail(string reciver,string title,string meesage);
    }
}
