namespace Factory_Pattern.ConcreteProducts;

public class ConcreteProduct1 : Product
{
    public override void Execute()
    {
        Console.WriteLine("ConcreteProduct1.Execute");
    }
}