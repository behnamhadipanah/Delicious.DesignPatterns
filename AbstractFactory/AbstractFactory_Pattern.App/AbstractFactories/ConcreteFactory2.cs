using AbstractFactory_Pattern.App.AbstractFactories;
using AbstractFactory_Pattern.App.Services.ProductA;
using AbstractFactory_Pattern.App.Services.ProductB;

public class ConcreteFactory2: IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ProductB2();

    }
}