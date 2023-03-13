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
            return View();
        }
    }
}
