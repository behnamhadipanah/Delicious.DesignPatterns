using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern.ConcreteElements
{
    public class ConcreteElementB:Element
    {
        
        public long OrderId { get; private set; }
        public ConcreteElementB(long orderId)
        {
            OrderId = orderId;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }
}
