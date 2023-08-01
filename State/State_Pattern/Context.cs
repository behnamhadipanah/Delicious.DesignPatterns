using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State_Pattern.ConcreteStates;
using State_Pattern.States;

namespace State_Pattern
{
    public class Context
    {
        public State State { get; set; }

        public Context()
        {
            //Set default state
            State = new ConcreteStateA();
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}
