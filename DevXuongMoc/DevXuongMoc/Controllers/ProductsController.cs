using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
