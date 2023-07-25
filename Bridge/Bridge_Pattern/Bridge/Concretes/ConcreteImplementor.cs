using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge_Pattern.Bridge.Implementors;

namespace Bridge_Pattern.Bridge.Concretes
{
    public class ConcreteImplementor : Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("Run  ConcreteImplementor.Implementation()");
        }
    }
}
