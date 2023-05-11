using Microsoft.AspNetCore.Mvc;

namespace TASK2_ASP.Contorllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
