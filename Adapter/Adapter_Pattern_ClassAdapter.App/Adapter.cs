namespace Adapter_Pattern_ClassAdapter.App;

public class Adapter : Adaptee, ITarget
{
    public void Operation()
    {
        SpecificOperation();
    }
}