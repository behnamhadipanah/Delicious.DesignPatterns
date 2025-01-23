namespace Ex.ChainOfResponsibility_Snap.App.Chain.Business;

public class CheckActiveUser : TakeTaxiHandler
{
    public override ResponseContext Execute(RequestContext request)
    {
        if (request.UserId > 0)
        {
            Console.WriteLine("user is active");

            if (CheckNext())
                return successor.Execute(request);
        }

        Console.WriteLine("User not active");
        return new ResponseContext()
        {
            IsSuccess = false,
            Message = "User not active"
        };

    }
}