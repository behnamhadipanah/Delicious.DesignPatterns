using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.State.ConsoleApp.Orders.ConcreteStates
{
    public class CancelledState : IOrderState
    {
        public OrderStatus Status => OrderStatus.Cancelled;
        public bool CanSend(Order order)
        {
            return 
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public bool CanDelivered(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("The order has been cancelled");
        }

        public void Sent(Order order)
        {
            throw new NotImplementedException("Canceled order cannot be shipped");

        }

        public void Delivered(Order order)
        {
            throw new NotImplementedException("Canceled order cannot be delivered");
        }
    }
}
