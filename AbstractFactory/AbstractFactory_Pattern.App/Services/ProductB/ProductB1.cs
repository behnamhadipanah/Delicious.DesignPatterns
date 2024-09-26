using AbstractFactory_Pattern.App.Services.ProductB;

public class ProductB1 : IAbstractProductB
{
    public void Execute()
    {
        Console.WriteLine("ProductB1");
    }
}