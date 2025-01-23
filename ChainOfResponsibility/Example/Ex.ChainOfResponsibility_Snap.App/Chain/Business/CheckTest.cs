namespace Ex.ChainOfResponsibility_Snap.App.Chain.Business;

public class CheckTest : TakeTaxiHandler
{
    public override ResponseContext Execute(RequestContext request)
    {
        Console.WriteLine("Check Test is Done");

        if (CheckNext())
        {
            return successor.Execute(request);
        }

        return new ResponseContext()
        {
            IsSuccess = false,
            Message = "Error"
        };
    }
}