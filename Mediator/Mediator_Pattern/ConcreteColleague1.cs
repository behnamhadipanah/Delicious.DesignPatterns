// See https://aka.ms/new-console-template for more information
public class ConcreteColleague1 : Colleague
{
    public override void Send(string message)
    {
        Console.WriteLine($"ConcreteColleague1 sending message ==> {message}");
        base.Send(message);
    }

    public  void Receive(string message)
    {
        Console.WriteLine($"ConcreteColleague1 Receive ==> {message}");
        
    }
}
