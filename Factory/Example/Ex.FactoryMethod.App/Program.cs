// See https://aka.ms/new-console-template for more information

using Ex.FactoryMethod.App.Sms;
using Ex.FactoryMethod.App.Sms.FactoryMethod;
using Ex.FactoryMethod.App.Sms.FirstCompanySender;

Console.WriteLine("Hello, World!");



ICreator creator = new Creator();

ISmsManager smsManager = creator.FactorySmsManager();

smsManager.Send(new SmsDto()
{
    Message = "test",
    Receiver = "09120000000"
});

Console.ReadKey();