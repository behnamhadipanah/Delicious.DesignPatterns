using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    public class ObjectStructure
    {
        public List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
