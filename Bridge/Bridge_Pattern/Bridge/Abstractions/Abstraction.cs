using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge_Pattern.Bridge.Concretes;
using Bridge_Pattern.Bridge.Implementors;

namespace Bridge_Pattern.Bridge.Abstractions
{
    public  abstract class Abstraction
    {
        private Implementor _implementor;

        public Abstraction()
        {
            _implementor = new ConcreteImplementor();
        }
        public virtual void Function()
        {
            _implementor.Implementation();
        }
    }
}
