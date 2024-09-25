using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.FactoryMethod.App.Sms
{
    //Product
    public interface ISmsManager
    {
        void Send(SmsDto sms);
        List<SmsDto> GetList();
    }

    public class SmsDto
    {
        public string Receiver { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
    }
}
