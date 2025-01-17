using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
