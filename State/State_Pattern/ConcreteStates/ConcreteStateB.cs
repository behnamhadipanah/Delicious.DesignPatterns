using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State_Pattern.States;

namespace State_Pattern.ConcreteStates
{
    public class ConcreteStateB:State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Request handle by ConcreteStateB");
            context.State = new ConcreteStateC();
        }
    }
}
