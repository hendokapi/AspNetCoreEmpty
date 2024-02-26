using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        // action
        public IActionResult Index()
        {
            ViewBag.title = "Sono la Home dalla ViewBag";
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
