namespace Visitor_Pattern_With_Overlodaing.ConcreteElements
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
            visitor.Visit(this);
        }
    }
}
