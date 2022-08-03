using Microsoft.AspNetCore.Mvc;

namespace Scratch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        //public String Index()
        {
            ViewData["title"] = "Home | Index";
            return View();
            //return "Home page Started";
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
