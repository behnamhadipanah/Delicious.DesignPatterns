// See https://aka.ms/new-console-template for more information



public abstract class Subject
{
    //Publisher
    private List<Observer> _observers;
    protected Subject()
    {
        _observers = new List<Observer>();
    }

    public void Attach( Observer observer)
    {
        _observers.Add(observer);
    }
    public  void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (Observer observer in _observers)
        {
            observer.Update();
        }
    }

}