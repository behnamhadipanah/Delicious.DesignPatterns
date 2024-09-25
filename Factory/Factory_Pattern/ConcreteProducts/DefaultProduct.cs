namespace Factory_Pattern.ConcreteProducts;

public class DefaultProduct : Product
{
    public override void Execute()
    {
        Console.WriteLine("DefaultProduct.Execute");

    }
}