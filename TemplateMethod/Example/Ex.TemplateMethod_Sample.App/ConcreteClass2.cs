using Ex.TemplateMethod_Sample.App;

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass2 .RequiredOperation1() => Run()");

    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass2 .RequiredOperation2() => Run()");

    }

    protected override void Hook1()
    {
        Console.WriteLine("ConcreteClass2 .Hook1() => Run()");

        base.Hook1();
    }
}