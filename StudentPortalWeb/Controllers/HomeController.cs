using Microsoft.AspNetCore.Mvc;
using StudentPortalWeb.Models;
using System.Diagnostics;

namespace StudentPortalWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expense()
        {
            return View();
        }
        public IActionResult CreateOrEdit()
        {
            return View();
        }

        public IActionResult CreateEditForm(Expense model) {
            return RedirectToAction(" Expense");
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
