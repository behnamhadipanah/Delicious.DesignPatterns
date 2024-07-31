namespace Composite_Pattern.CompositesClass;

public class Composite : Component
{
    private List<Component> _components = new List<Component>();

    public Composite(string name) : base(name)
    {
    }

    public Composite( string name, Component[] components):base(name)
    {
        foreach (var component in components)
        {
            Add(component);
        }
    }
    public override void Add(Component component)
    {
        _components.Add(component);
    }

    public override void Remove(Component component)
    {
        _components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }
}