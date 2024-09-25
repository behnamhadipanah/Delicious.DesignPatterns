using Ex.FactoryMethod.App.Sms.FirstCompanySender;
using Ex.FactoryMethod.App.Sms.SecondCompanySender;

namespace Ex.FactoryMethod.App.Sms.FactoryMethod;

public class Creator : ICreator
{
    public ISmsManager FactorySmsManager()
    {
        string appconfig = "iran";
        
        if (appconfig.Equals("OtherCountry"))
        {
            return new SecondCompanySmsManager();
        }

        return new FirstCompanySmsManager();

    }
}