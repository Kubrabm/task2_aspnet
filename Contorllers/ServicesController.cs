using Microsoft.AspNetCore.Mvc;

namespace TASK2_ASP.Contorllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
