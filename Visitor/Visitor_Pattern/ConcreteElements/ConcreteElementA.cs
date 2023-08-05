using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern.ConcreteElements
{
    public class ConcreteElementA:Element
    {
        public string Name { get; private set; }
        public ConcreteElementA(string name)
        {
            Name = name;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }
}
