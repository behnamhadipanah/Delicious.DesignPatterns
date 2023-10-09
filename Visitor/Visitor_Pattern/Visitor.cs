using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.ConcreteElements;

namespace Visitor_Pattern
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA element);
        public abstract void VisitConcreteElementB(ConcreteElementB element);
    }
}
