using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.State.ConsoleApp.Orders
{

    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState orderState)
        {
            _orderState=orderState;
        }

        public void ChangeState(IOrderState orderState)
        {
            _orderState = orderState;
        }
        public long Id { get; set; }
        public string Customer { get; set; }
        public DateTime CreateDate { get; set; }


        public void Send()
        {
            _orderState.Sent(this);
        }

        public void Cancel()
        {
            _orderState.Cancel(this);
        }

        public void Delivered()
        {
            _orderState.Delivered(this);
        }

    }
}
