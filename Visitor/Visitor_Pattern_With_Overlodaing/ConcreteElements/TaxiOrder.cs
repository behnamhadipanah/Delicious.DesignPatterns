namespace Visitor_Pattern_With_Overlodaing.ConcreteElements;

public class TaxiOrder:Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}