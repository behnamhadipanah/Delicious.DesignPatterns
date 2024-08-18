using Prototype_Pattern.App;

public class ConcretePrototype2 : IPrototype
{
    public ConcretePrototype1 MyApplicationService { get; set; }

    public ConcretePrototype2(ConcretePrototype1 myApplicationService)
    {
        MyApplicationService = myApplicationService;
    }
    public IPrototype Clone()
    {
        var result = (ConcretePrototype2)this.MemberwiseClone();
        result.MyApplicationService = (ConcretePrototype1)this.MyApplicationService.Clone();
        return (IPrototype)result;
    }
}