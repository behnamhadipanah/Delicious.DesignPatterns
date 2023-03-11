using System.Xml.Serialization;

namespace Decorator_Pattern;

/* Add New Feature */
public class ConcreteDecorator:Decorator
{
    public ConcreteDecorator(Component component) : base(component)
    {
    }
    public override void operation()
    {
        base.operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("This is Write at NewFeature()");
    }
    
}