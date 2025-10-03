using Microsoft.AspNetCore.Mvc;

namespace ThfnhView.Controllers
{
    public class PassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "Thanh Dinh";
            ViewData["time"] = DateTime.Now;
            return View();

            //Object
            var student = new Student
            {
                Id = 1,
                Name = 
            }
        }
        
    }
}
