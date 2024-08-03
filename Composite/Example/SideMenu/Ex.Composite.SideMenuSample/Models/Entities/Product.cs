namespace Ex.Composite.SideMenuSample.Models.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CategoryItem CategoryItem { get; set; }
    public int CategoryItemId { get; set; }
}