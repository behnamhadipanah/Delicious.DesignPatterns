// See https://aka.ms/new-console-template for more information


public class ConcreteObserver : Observer
{
    public string Name { get; set; }
    private string ObserverState { get; set; }

    public ConcreteSubject ConcreteSubject { get; set; }


    public ConcreteObserver(string name, ConcreteSubject concreteSubject)
    {
        Name = name;
        ConcreteSubject = concreteSubject;
    }

    public override void Update()
    {
        ObserverState = ConcreteSubject.SubjectState;
        Console.WriteLine($"{Name} ObserverState Update = {ConcreteSubject.SubjectState}");
    }
}