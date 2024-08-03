// See https://aka.ms/new-console-template for more information

using Ex.Bridge.EmailSender.Dtos;
using Ex.Bridge.EmailSender.MailService.Abstractions;


MailServiceAbstraction mailService =new RefinedMailServiceAbstraction ();
var emailInfo = new EmailInformationDto()
{
    Receiver =  "behnamhadipanah@gmail.com",
    Message = "Welcome to Example Bridge design pattern",
    Title = "Bridge design pattern"
};
mailService.Send(emailInfo);

Console.ReadKey();