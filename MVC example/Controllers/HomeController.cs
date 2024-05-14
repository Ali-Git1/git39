using Microsoft.AspNetCore.Mvc;

namespace MVC_example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ali";
            ViewBag.SurName = "Aliyev";
            ViewBag.Age = 21;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = 0777777777;


            return View();
        }
    }
}
