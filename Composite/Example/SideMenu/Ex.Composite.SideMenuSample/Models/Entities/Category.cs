using Microsoft.AspNetCore.Mvc.Formatters;

namespace Ex.Composite.SideMenuSample.Models.Entities;

public class Category : CategoryComponent
{
    public readonly List<CategoryComponent> _menuComponents = new List<CategoryComponent>();
    public ICollection<CategoryComponent> MenuItems => _menuComponents;

    public Category(string name)
    {
        Name = name;
    }

    protected Category()
    {

    }

    public void Add(CategoryComponent categoryComponent)
    {
        _menuComponents.Add(categoryComponent);
    }

    public void Remove(CategoryComponent categoryComponent)
    {
        _menuComponents.Remove(categoryComponent);

    }

    public override string Print()
    {
        string ul = $@"<ul> {Name}";
        foreach (var menuComponent in _menuComponents)
        {
            ul += menuComponent.Print();
        }

        ul += $@"</ul>";

        return ul;
    }

}