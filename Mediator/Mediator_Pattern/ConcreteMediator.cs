// See https://aka.ms/new-console-template for more information
public class ConcreteMediator : Mediator
{
    public ConcreteMediator(ConcreteColleague1 colleague1, ConcreteColleague2 colleague2):base(colleague1, colleague2)
    {
        
    }

    public override void NotifyChange(string message, Colleague colleague)
    {
        if (colleague == _concreteColleague1) 
            _concreteColleague2.Receive(message);
        else
        _concreteColleague1.Receive(message);

    }
}
