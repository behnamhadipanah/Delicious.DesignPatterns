// See https://aka.ms/new-console-template for more information
public abstract class Colleague
{
    protected Mediator Mediator;
    public void SetMediator(Mediator mediator)
    {
        Mediator = mediator;
    }
    public virtual void Send( string message)
    {
        Mediator.NotifyChange(message, this);
    }
}
