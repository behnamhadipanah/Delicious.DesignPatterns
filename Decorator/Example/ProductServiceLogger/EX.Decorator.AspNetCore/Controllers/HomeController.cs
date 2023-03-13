using EX.Decorator.AspNetCore.Decorator;
using Ex.Decorator.Domain;
using Ex.Decorator.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EX.Decorator.AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAddNewProductService _addNewProductService;

        public HomeController(ILogger<HomeController> logger, IAddNewProductService addNewProductService)
        {
            _logger = logger;
            _addNewProductService = addNewProductService;
        }
        public IActionResult Index()
        {
            var loggingDecorator = new LoggingDecorator(_addNewProductService,null);
            loggingDecorator.Execute(new Product()
            {
                Id = 1,
                Title = "Product1"
            });
            return View();
        }
    }
}
