internal class ConcreteFlyweight : Flyweight
{
  
    private string _intrinsicState;

    public ConcreteFlyweight(string intrinsicState)
    {
     // TODO : وضعیت درونی
        _intrinsicState = intrinsicState;
    }

  


    public override void Operation(string extrinsicState)
    {
        //TODO : وضعیت بیرونی
        Console.WriteLine("ConcreteFlyweight.Operation('"+_intrinsicState +"'):\""+ extrinsicState +"\"");
    }
}