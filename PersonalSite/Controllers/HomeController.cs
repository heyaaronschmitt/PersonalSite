using Microsoft.AspNetCore.Mvc;
using PersonalSite.Models;
using System.Diagnostics;

namespace PersonalSite.Controllers
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

        public IActionResult PortfolioOverview() 
        {
            return View();
        }

        public IActionResult PortfolioItem() 
        {
            return View();
        }

        public IActionResult Resume() 
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
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