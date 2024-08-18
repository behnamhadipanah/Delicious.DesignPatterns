using Prototype_Pattern.App;

public class ConcretePrototype1 : IPrototype
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    public ConcretePrototype1(int property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }
    public IPrototype Clone()
    {
        return (IPrototype)this.MemberwiseClone();
    }
}