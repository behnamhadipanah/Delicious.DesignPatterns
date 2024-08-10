using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Adapter.Notification.App.Notifications
{
    public interface ISendMessage
    {
        void Send(string message);
    }
}