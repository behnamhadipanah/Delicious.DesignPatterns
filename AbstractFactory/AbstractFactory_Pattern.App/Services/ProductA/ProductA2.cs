using AbstractFactory_Pattern.App.Services.ProductA;

public class ProductA2 : IAbstractProductA
{
    public void Execute()
    {
        Console.WriteLine("ProductA2");
    }
}