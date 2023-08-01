using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.State.ConsoleApp.Orders.ConcreteStates
{
    public class WaitingToSendState : IOrderState
    {
        public OrderStatus Status
        {
            get
            {
                return OrderStatus.WaitingToSend;
            }
        }
        public bool CanSend(Order order)
        {
            return true;
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public bool CanDelivered(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            
            Console.WriteLine("The order was cancelled");
            order.ChangeState(new CancelledState());
            
        }

        public void Sent(Order order)
        {
            Console.WriteLine("The order was sent");
            order.ChangeState(new SentState());
        }

        public void Delivered(Order order)
        {
            throw new NotImplementedException("The order cannot be delivered before the order is sent");
        }
    }
}
