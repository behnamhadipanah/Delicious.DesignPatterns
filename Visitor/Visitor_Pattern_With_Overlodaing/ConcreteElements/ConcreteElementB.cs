namespace Visitor_Pattern_With_Overlodaing.ConcreteElements
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
            visitor.Visit(this);
        }
    }
}
