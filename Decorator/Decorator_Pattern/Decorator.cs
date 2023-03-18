namespace Decorator_Pattern;

public abstract class Decorator : Component
{
    private readonly Component _component;

    protected Decorator(Component component)
    {
        _component = component;
    }

    public override void operation()
    {
        _component.operation();
    }

}
