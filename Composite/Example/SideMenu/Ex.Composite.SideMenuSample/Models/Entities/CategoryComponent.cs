namespace Ex.Composite.SideMenuSample.Models.Entities
{
    public abstract class CategoryComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string Print()
        {
            throw new NotSupportedException();
        }
    }
}
