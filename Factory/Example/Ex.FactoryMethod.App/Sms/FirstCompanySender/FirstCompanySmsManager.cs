namespace Ex.FactoryMethod.App.Sms.FirstCompanySender
{
    //Concrete Product1
    public class FirstCompanySmsManager : ISmsManager
    {
        public void Send(SmsDto sms)
        {
            Console.WriteLine("Send sms with first Company");
        }

        public List<SmsDto> GetList()
        {
            List<SmsDto> sms = new List<SmsDto>();
            return sms;
        }
    }
}
