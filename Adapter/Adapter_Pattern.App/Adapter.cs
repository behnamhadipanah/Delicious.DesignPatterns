using Adapter_Pattern.App;

public class Adapter : Target
{
    private Adaptee _adaptee;

    public Adapter()
    {
        _adaptee=new Adaptee();
    }
    public override void Operation()
    {
        _adaptee.SpecificOperation();
    }
}