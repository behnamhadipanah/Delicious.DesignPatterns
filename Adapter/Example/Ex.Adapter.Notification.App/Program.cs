// See https://aka.ms/new-console-template for more information

using Ex.Adapter.Notification.App.Notifications;

Console.WriteLine("Hello, World!");



ISendMessage telegram=new Telegram();
telegram.Send("register is ok");

ISendMessage whatsApp = new WhatsApp();
whatsApp.Send("register is ok");


ISendMessage gmailMessage = new GMailAdapter();
gmailMessage.Send("register ok");


Console.ReadKey();