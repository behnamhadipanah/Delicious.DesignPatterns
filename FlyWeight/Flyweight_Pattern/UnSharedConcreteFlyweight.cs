using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    public class UnSharedConcreteFlyweight:Flyweight
    {
        private IEnumerable<Flyweight> _flyweights;

        public UnSharedConcreteFlyweight(IEnumerable<Flyweight> flyweights)
        {
            _flyweights = flyweights;
        }
        public override void Operation(string extrinsicState)
        {
            foreach (var flyweight in _flyweights)
            {
                flyweight.Operation(extrinsicState);
            }
        }
    }
}
