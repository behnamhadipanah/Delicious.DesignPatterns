public class Caretaker
{
    Memento _memento;
    public Memento Memento
    {
        get { return _memento; }
        set
        {
            _memento = value;
            Console.WriteLine("Caretaker set memento...");
        }
    }
}
