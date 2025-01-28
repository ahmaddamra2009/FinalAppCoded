using System.Diagnostics;
using FinalAppCoded.Data;
using FinalAppCoded.Models;
using FinalAppCoded.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalAppCoded.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            CatCourseEventsViewModel model=new CatCourseEventsViewModel() 
            {
                Coruses=db.Courses.OrderByDescending(x=>x.CourseId).Take(6).ToList(),
                Events= db.Events.ToList(),
                Categories=db.Categories.ToList()
            };
            ViewBag.EventsCount = db.Events.Count();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
