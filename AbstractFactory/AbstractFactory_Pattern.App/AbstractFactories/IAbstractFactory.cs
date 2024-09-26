using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Pattern.App.Services.ProductA;
using AbstractFactory_Pattern.App.Services.ProductB;

namespace AbstractFactory_Pattern.App.AbstractFactories
{
    public interface IAbstractFactory
    {
        /*
         * for real project is productRepository,SmsManager,emailManager,....
         */
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();

    }
}