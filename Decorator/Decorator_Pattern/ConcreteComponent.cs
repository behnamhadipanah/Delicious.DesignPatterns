namespace Decorator_Pattern;


public class ConcreteComponent : Component
{
    public override void operation()
    {
        Console.WriteLine("ConcreteComponent.operation");
    }
}