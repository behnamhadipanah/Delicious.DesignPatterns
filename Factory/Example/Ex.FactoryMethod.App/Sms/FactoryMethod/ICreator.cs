using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.FactoryMethod.App.Sms.FactoryMethod
{
    public interface ICreator
    {

        ISmsManager FactorySmsManager();
    }
}
