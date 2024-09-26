using AbstractFactory_Pattern.App.AbstractFactories;
using AbstractFactory_Pattern.App.Services.ProductA;
using AbstractFactory_Pattern.App.Services.ProductB;

public class ConcreteFactory1:IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}