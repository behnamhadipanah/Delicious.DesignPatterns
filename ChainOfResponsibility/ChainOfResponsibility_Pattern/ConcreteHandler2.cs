namespace ChainOfResponsibility_Pattern;

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 50)
        {
            Console.WriteLine($"ConcreteHandler2 {request}.");
        }
        else if (_successor!=null)
        {
            _successor.HandleRequest(request);
        }
    }
}