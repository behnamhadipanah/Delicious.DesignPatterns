public abstract class TakeTaxiHandler : IHandler
{
    protected IHandler successor;
    public IHandler SetNext(IHandler handler)
    {
        successor = handler;
        return successor;
    }

    public abstract ResponseContext Execute(RequestContext request);

    protected bool CheckNext()
    {
        return successor is null ? false : true;
    }

}