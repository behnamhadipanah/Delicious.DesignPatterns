public abstract class Command
{
    protected Receiver _receiver;

    protected Command(Receiver receiver)
    {
        _receiver = receiver;
    }
    public abstract void Execute();
}