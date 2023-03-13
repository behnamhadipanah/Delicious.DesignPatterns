using Ex.Decorator.Domain;
using Ex.Decorator.Repository;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Logging;

namespace EX.Decorator.AspNetCore.Decorator;

public class LoggingDecorator:AddNewProductServiceDecorator
{
    private readonly ILogger<LoggingDecorator> _logger;

    public LoggingDecorator(IAddNewProductService addNewProductService, ILogger<LoggingDecorator> logger) : base(addNewProductService)
    {
        _logger = logger;
    }

    public void Execute(Product product)
    {
        _logger.LogInformation("Before Add");
        base.Execute(product);
        _logger.LogInformation("After Information");
    }
}