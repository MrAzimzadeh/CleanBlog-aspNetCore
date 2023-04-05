using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Areas.Dashboard.Controllers
{
    [Area(nameof(Dashboard))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
