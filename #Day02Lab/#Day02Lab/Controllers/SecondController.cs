using Microsoft.AspNetCore.Mvc;

namespace _Day02Lab.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
