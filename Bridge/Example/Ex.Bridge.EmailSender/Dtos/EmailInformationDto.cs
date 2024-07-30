using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Bridge.EmailSender.Dtos
{
    public class EmailInformationDto
    {
        public string Receiver { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
