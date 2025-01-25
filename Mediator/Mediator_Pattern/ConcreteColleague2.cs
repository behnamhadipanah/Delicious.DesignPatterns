// See https://aka.ms/new-console-template for more information
public class ConcreteColleague2 : Colleague
{
    public override void Send(string message)
    {
        Console.WriteLine($"ConcreteColleague2 sending message ==> {message}");
        base.Send(message);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"ConcreteColleague2 Receive ==> {message}");

    }
}