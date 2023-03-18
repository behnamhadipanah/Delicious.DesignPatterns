using Ex.Decorator.Domain;

namespace Ex.Decorator.Repository
{
    public interface IAddNewProductService
    {
        void Execute(Product product);
    }
}