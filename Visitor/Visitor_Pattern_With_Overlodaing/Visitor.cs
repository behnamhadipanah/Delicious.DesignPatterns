using Visitor_Pattern_With_Overlodaing.ConcreteElements;

namespace Visitor_Pattern_With_Overlodaing
{
    public class Visitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine($"Type: {element.GetType().Name} Name:{element.Name} Visitor:{this.GetType().Name}");
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine($"Type: {element.GetType().Name} OrderID:{element.OrderId} Visitor:{this.GetType().Name}");
        }

        public void Visit(TaxiOrder element)
        {
            Console.WriteLine($"Type: {element.GetType().Name} Visitor:{this.GetType().Name}");
            
        }
        public void Visit(MarketOrder element)
        {
            Console.WriteLine($"Type: {element.GetType().Name} Visitor:{this.GetType().Name}");
        }
    }
}
