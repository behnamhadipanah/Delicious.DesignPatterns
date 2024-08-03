namespace Ex.Composite.SideMenuSample.Models.Entities;

public class CategoryItem : CategoryComponent
{
    public string Link { get; set; }

    public CategoryItem(string name, string link)
    {
        Name = name;
        Link = link;
    }

    protected CategoryItem()
    {

    }

    public override string Print()
    {
        string li = @$"<li> <a href='{Link}'>{Name}</a></li>";
        return li;
    }
}