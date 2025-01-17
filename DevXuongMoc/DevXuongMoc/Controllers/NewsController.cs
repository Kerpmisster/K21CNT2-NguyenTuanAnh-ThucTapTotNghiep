using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
