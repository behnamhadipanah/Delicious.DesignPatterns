namespace ChainOfResponsibility_Pattern;

public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 50)
        {
            Console.WriteLine($"ConcreteHandler1 {request}.");
        }
        else
        {
            _successor.HandleRequest(request);
            
        }
    }
}