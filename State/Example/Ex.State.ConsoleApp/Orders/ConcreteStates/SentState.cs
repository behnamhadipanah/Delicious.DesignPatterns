using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.State.ConsoleApp.Orders.ConcreteStates
{
    public class SentState:IOrderState
    {
        public OrderStatus Status => OrderStatus.Sent;
        public bool CanSend(Order order)
        {
            return false;
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public bool CanDelivered(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {

            Console.WriteLine("The order was cancelled");
            order.ChangeState(new CancelledState());
        }

        public void Sent(Order order)
        {
            throw new NotImplementedException("The order is being sent");
        }

        public void Delivered(Order order)
        {
            Console.WriteLine("Order Delivery ");
            order.ChangeState(new DeliveredState());

        }
    }
}
