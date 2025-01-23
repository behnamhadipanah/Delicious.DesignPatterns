// See https://aka.ms/new-console-template for more information

using System.Xml;
using Ex.ChainOfResponsibility_Snap.App.Chain.Business;

Console.WriteLine("Hello, World!");


CreateOrder createOrder=new CreateOrder();
SendOrderToDriver sendOrderToDriver=new SendOrderToDriver();
CheckActiveUser checkActiveUser = new CheckActiveUser();
CheckTest checkTest = new CheckTest();

checkActiveUser
    .SetNext(createOrder)
    .SetNext(checkTest)
    .SetNext(sendOrderToDriver);

checkActiveUser.Execute(new RequestContext()
{
    UserId = 1,
    Origin = new Point(){Lat = 53.3636,Lng = 54.22},
    Destination = new Point() { Lat = 53.3636, Lng = 54.22 }
});

Console.ReadKey();