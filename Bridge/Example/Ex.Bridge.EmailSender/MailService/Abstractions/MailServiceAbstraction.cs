using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex.Bridge.EmailSender.Dtos;
using Ex.Bridge.EmailSender.MailService.Bridge;

namespace Ex.Bridge.EmailSender.MailService.Abstractions
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceBridge _mailServiceBridge;

        public MailServiceAbstraction(IMailServiceBridge bridge)
        {
            _mailServiceBridge = bridge;
        }
        public virtual void Send(EmailInformationDto email){}
    }
}


