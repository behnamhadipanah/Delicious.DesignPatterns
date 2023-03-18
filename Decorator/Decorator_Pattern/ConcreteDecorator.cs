using System.Xml.Serialization;

namespace Decorator_Pattern;

/* Add New Feature */
public class ConcreteDecorator:Decorator
{
    private bool isRunFirst = false;
    public ConcreteDecorator(Component component) : base(component)
    {
        #region Solve Problem 1

        ConcreteDecorator concreteDecorator=component as ConcreteDecorator;
        if (concreteDecorator is not null)
            isRunFirst = true;

        #endregion
    }
    public override void operation()
    {
        if (isRunFirst)
            return;
        base.operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("This is Write at NewFeature()");
    }
    
}

public class ConcreteDecorator2 : Decorator
{
    public ConcreteDecorator2(Component component) : base(component)
    {
    }
    public override void operation()
    {
        base.operation();
        NewFeature2();
    }

    public void NewFeature2()
    {
        Console.WriteLine("This is Write at NewFeature2()");
    }

}


public class NewDecorator : Decorator
{
    public NewDecorator(Component component) : base(component)
    {
        // Add New Featuer
    }

    public override void operation()
    {
        base.operation();
    }
}

public class MyDecorator : NewDecorator
{
    public MyDecorator(Component component):base(component)
    {
        
    }

    public override void operation()
    {
        base.operation();
    }
}