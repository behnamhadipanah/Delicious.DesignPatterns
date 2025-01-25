using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    public class Originator
    {
        private readonly string key = "memntoKey";
        private string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"State= {state}");
            }
        }

        public Memento CreateMemento()
        {
            Console.WriteLine("Saving State.....");
            return new Memento(state);
        }
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("restoring state");
            State = memento.State;
        }
    }
}
