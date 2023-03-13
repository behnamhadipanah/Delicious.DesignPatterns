using Ex.Decorator.Domain;
using Ex.Decorator.Repository;

namespace EX.Decorator.AspNetCore.Decorator;

public abstract class AddNewProductServiceDecorator: IAddNewProductService
{
    private readonly IAddNewProductService _addNewProductService;

    public AddNewProductServiceDecorator(IAddNewProductService addNewProductService)
    {
        _addNewProductService = addNewProductService;
    }
    public void Execute(Product product)
    {
        _addNewProductService.Execute(product);

    }
}