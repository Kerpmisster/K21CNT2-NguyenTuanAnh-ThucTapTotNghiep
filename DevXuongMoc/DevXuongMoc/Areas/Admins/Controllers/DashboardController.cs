using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Areas.Admins.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly NoiThatHoangHoanContext _context;
        public DashboardController(NoiThatHoangHoanContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Sử dụng context của DbContext để lấy số lượng
            var productCount = _context.Products.Count();
            var userCount = _context.Customers.Count();
            var contactCount = _context.Contacts.Count();

            // Truyền dữ liệu qua ViewData
            ViewData["ProductCount"] = productCount;
            ViewData["UserCount"] = userCount;
            ViewData["ContactCount"] = contactCount;

            return View();
        }
    }
}
