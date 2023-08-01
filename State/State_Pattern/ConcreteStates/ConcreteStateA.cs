using State_Pattern.States;

namespace State_Pattern.ConcreteStates
{
    public class ConcreteStateA:State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Request handle by ConcreteStateA");
            context.State = new ConcreteStateB();
        }
    }
}
