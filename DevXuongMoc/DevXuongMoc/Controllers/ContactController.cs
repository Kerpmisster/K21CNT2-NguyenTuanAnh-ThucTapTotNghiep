using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
