using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.ChainOfResponsibility_Snap.App.Chain.Business
{
    public class CreateOrder:TakeTaxiHandler
    {
        public override ResponseContext Execute(RequestContext request)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                Console.WriteLine("Order Created .....");
                if (successor!=null)
                    return successor.Execute(request);

            }

            return new ResponseContext()
            {
                IsSuccess = false, Message = "Error Order Created"
            };
        }
    }
}
