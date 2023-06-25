using HW8.Models;
using HW8.Ripository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserRipository _userRipository;

        public HomeController(ILogger<HomeController> logger, IUserRipository userRipository)
        {
            _logger = logger;
            _userRipository = userRipository;
        }

        public IActionResult Index()
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