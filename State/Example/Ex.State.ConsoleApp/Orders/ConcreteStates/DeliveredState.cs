using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.State.ConsoleApp.Orders.ConcreteStates
{
    public class DeliveredState:IOrderState
    {
        public OrderStatus Status => OrderStatus.Delivered;
        public bool CanSend(Order order)
        {
            return false;
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public bool CanDelivered(Order order)
        {
            throw new NotImplementedException();
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Order delivered");
        }

        public void Sent(Order order)
        {
            throw new NotImplementedException("The order has been delivered and you cannot resend it");
        }

        public void Delivered(Order order)
        {
            throw new NotImplementedException("The order has already been sent");
        }
    }
}
