namespace TemplateMethod_Pattern.App;

public class ConcreteClass : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClass.PrimitiveOperation1()");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClass.PrimitiveOperation2()");

    }
}