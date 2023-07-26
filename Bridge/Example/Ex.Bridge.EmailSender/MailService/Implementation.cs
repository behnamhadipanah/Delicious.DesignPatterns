using Ex.Bridge.EmailSender.MailService.Bridge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Bridge.EmailSender.MailService
{
    public static class Implementation
    {
        public static IMailServiceBridge GetImplementor()
        {
            var config = ConfigurationManager.AppSettings;

            switch (config["EmailService"].ToLower().Trim())
            {
                case "gmail":
                    return new GmailService();
                case "yahoo":
                    return new YahooService();
                default:
                    return new GmailService();
            }
        }
    }
}
