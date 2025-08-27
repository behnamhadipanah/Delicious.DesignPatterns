namespace Visitor_Pattern_With_Overlodaing.ConcreteElements;

public class MarketOrder:Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}