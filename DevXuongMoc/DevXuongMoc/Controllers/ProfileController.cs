using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
