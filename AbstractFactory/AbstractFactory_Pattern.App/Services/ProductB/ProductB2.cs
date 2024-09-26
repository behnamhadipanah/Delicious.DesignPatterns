using AbstractFactory_Pattern.App.Services.ProductB;

public class ProductB2 : IAbstractProductB
{
    public void Execute()
    {
        Console.WriteLine("ProductB2");
    }
}