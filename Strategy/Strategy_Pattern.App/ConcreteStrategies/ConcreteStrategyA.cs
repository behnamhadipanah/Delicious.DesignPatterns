using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.App.ConcreteStrategies
{
    public class ConcreteStrategyA:IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
