using Microsoft.AspNetCore.Mvc;

namespace FinalAppCoded.Areas.Administrator.Controllers
{
  
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
