using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.FactoryMethod.App.Sms.SecondCompanySender
{
    //Concrete Product 2
    public class SecondCompanySmsManager:ISmsManager
    {
        public void Send(SmsDto sms)
        {
            Console.WriteLine("Send sms with second Company");
        }

        public List<SmsDto> GetList()
        {
            List<SmsDto> sms = new List<SmsDto>();
            return sms;
        }
    }
}
