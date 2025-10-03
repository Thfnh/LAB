using Microsoft.AspNetCore.Mvc;

namespace _Day02Lab.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
