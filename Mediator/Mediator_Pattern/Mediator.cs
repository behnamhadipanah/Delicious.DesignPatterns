// See https://aka.ms/new-console-template for more information
public abstract class Mediator
{
    protected ConcreteColleague1 _concreteColleague1;
    protected ConcreteColleague2 _concreteColleague2;
    protected Mediator(ConcreteColleague1 colleague1,ConcreteColleague2 colleague2)
    {
        _concreteColleague1 = colleague1;
        _concreteColleague2 = colleague2;
    }
    public abstract void NotifyChange(string message,Colleague colleague);


}
