using Ex.Composite.SideMenuSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ex.Composite.SideMenuSample.Models.Contexts;
using Ex.Composite.SideMenuSample.Models.Entities;

namespace Ex.Composite.SideMenuSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var menus = _context.CategoryComponents.ToList();
            string result = "";
            foreach (var menu in menus.Where(x => x.GetType() == typeof(Category)))
            //foreach (var menu in menus.Where(x => x.GetType() == typeof(CategoryItem)))
            {
                //_context.Products.Add(new Product
                //{
                //    Name = "test",
                //    CategoryItem = menu as CategoryItem,
                //});
                //_context.SaveChanges();

                result += menu.Print();
            }

            return View("Index",result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TempData()
        {
            var category = new Category("محصولات");
            category.Add(new CategoryItem("موبایل", "http://behnamhadipanah.ir/mobile"));
            category.Add(new CategoryItem("لپ تاپ", "http://behnamhadipanah.ir/laptop"));
            category.Add(new CategoryItem("کتاب", "http://behnamhadipanah.ir/book"));

            _context.CategoryComponents.Add(category);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
