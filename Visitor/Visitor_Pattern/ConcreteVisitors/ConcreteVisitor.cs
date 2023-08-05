using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.ConcreteElements;

namespace Visitor_Pattern.Visitors
{
    public class ConcreteVisitor : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine($"Type: {element.GetType().Name} Name:{element.Name} Visitor:{this.GetType().Name}");
        }

        public override void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine($"Type: {element.GetType().Name} OrderID:{element.OrderId} Visitor:{this.GetType().Name}");
        }
    }
}
