using Ex.Composite.SideMenuSample.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ex.Composite.SideMenuSample.Models.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=CompositeDbAsp;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CategoryComponent> CategoryComponents { get; set; }
        private DbSet<Category> Categories { get; set; }
        private DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
