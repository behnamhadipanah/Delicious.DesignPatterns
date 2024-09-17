using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Pattern.ConcreteProducts;

namespace Factory_Pattern;
public abstract class Product //for example send email
{
    public abstract void Execute();
}

public abstract class CreatorFactory
{
    public abstract Product FactoryMethod(int i);
}

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