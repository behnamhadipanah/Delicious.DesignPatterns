using Factory_Pattern.ConcreteProducts;

namespace Factory_Pattern;

public class ConcreteCreatorFactory : CreatorFactory
{
    public override Product FactoryMethod(int i)
    {
        if (i < 0)
            return new ConcreteProduct1();

        else  if (i > 0)
            return new ConcreteProduct2();
        else
        {
            return new DefaultProduct();
        }


    }
}