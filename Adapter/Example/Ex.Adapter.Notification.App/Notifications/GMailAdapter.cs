using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailService;

namespace Ex.Adapter.Notification.App.Notifications
{
    public class GMailAdapter:GmailServiceGoogle,ISendMessage
    {
        public void Send(string message)
        {
            SendMail(message);
        }
    }

    //public class GMailAdapter :  ISendMessage
    //{
    //    private GmailServiceGoogle _gmailServiceGoogle;

    //    public GMailAdapter()
    //    {
    //        _gmailServiceGoogle = new GmailServiceGoogle();
    //    }
    //    public void Send(string message)
    //    {
    //        _gmailServiceGoogle.SendMail(message);
    //    }
    //}
}
