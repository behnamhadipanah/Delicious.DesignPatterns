using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.State.ConsoleApp.Orders
{
    /// <summary>
    /// state
    /// </summary>
    public interface IOrderState
    {
        OrderStatus Status { get; }


        bool CanSend(Order order);
        bool CanCancel(Order order);
        bool CanDelivered(Order order);

        void Cancel(Order order);
        void Sent(Order order);
        void Delivered(Order order);


    }
}
