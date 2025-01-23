namespace Ex.ChainOfResponsibility_Snap.App.Chain.Business;

public class SendOrderToDriver : TakeTaxiHandler
{
    public override ResponseContext Execute(RequestContext request)
    {
        Console.WriteLine("Send To Driver");
        if (CheckNext())
            return successor.Execute(request);

        return new ResponseContext()
        {
            IsSuccess = true,
            Message = "Order create and send to driver"
        };
    }
}