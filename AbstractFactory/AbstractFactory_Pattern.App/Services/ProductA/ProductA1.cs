using AbstractFactory_Pattern.App.Services.ProductA;

public class ProductA1 : IAbstractProductA
{
    public void Execute()
    {
        Console.WriteLine("ProductA1");
    }
}