using Microsoft.AspNetCore.Mvc;

namespace CulturalHeritageWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }
    }
}
