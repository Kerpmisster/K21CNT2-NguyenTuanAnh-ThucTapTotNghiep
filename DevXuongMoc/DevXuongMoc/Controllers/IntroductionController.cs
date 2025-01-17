using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
