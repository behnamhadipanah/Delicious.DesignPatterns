// See https://aka.ms/new-console-template for more information

using Ex.Decorator.Email;

Console.WriteLine("Hello, Send Email Decorator!");
var sendEmail = new SendEmail();
var sendEmailDecorator = new SendEmailDecorator(sendEmail);
sendEmailDecorator.Send();

Console.ReadLine();