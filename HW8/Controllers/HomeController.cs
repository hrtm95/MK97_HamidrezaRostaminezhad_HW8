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

        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            var user = _userRipository.Login(username, password);
            if (user != null) 
            {
                return View("Privacy");
            }
            return View("Login");
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