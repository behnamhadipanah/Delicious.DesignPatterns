namespace Ex.Composite.Computer;

public class Composite : IComponent
{
    public string Name { get; set; }
    public int Price { get; set; }
    private List<IComponent> _components=new List<IComponent>();

    public Composite(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public void AddComponent(IComponent component)
    {
        _components.Add(component);
    }
    public void AddComponents(List<IComponent> components)
    {
        _components.AddRange(components);
    }
    public int DisplayPrice()
    {
        int sum = Price;
        foreach (var component in _components)
        {
            sum += component.DisplayPrice();
        }
        Console.WriteLine(Name + " : " + sum);
        return sum;
    }
}