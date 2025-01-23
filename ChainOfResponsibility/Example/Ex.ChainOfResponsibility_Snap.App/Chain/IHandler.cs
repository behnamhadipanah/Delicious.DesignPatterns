public interface IHandler
{
    IHandler SetNext(IHandler handler);
    ResponseContext Execute(RequestContext request);
}