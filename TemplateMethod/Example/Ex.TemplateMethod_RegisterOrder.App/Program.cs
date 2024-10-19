// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ClientRegisterOrder.Execute(new EmailNotification());
Console.WriteLine("---------------------------------------------------");
ClientRegisterOrder.Execute(new SmsNotification());


Console.ReadKey();