using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern;
public abstract class Product //for example send email
{
    public abstract void Execute();
}

public abstract class CreatorFactory
{
    public abstract Product FactoryMethod(int i);
}