using Microsoft.AspNetCore.Mvc;

namespace Town.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}