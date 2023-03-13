using Ex.Decorator.Domain;

namespace Ex.Decorator.Repository
{
    public interface IAddNewProductService
    {
        void Execute(Product product);
    }

    public class AddNewProductService : IAddNewProductService
    {
        public void Execute(Product product)
        {
            throw new NotImplementedException();
        }
    }
}