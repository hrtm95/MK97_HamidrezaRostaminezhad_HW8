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
        private readonly ITurnoverRiposytory _turnoverRiposytory;

        public HomeController(ILogger<HomeController> logger, IUserRipository userRipository, ITurnoverRiposytory turnoverRiposytory)
        {
            _logger = logger;
            _userRipository = userRipository;
            _turnoverRiposytory = turnoverRiposytory;
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
                var remaining =  _turnoverRiposytory.remaining(user.Id);
                ViewBag.Remaining = remaining;
                return View("Profile", user);
            }
            return View("Login");
        }

        public IActionResult Profile()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int id)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ShowTurnover(int id)
        {
            var turnover = _turnoverRiposytory.Turnovers(id);
            if (turnover != null)
                return View(turnover);
            var user = _userRipository.GetUserById(id);
            return View("Profile", user);

        }
        public IActionResult AccountDeposit(int id)
        {
            return View(id);
        }

        [HttpPost]
            public IActionResult AccountDeposit (Turnover turnover)
        {
            int userid = turnover.userId;
            var Deposit = _turnoverRiposytory.AddTurnover(turnover);
            if (Deposit)
                return RedirectToAction("ShowTurnover", new { id = userid });
            var user = _userRipository.GetUserById(turnover.userId);
            return View("Profile", user);
        }

        public IActionResult Remaining(int id)
        {
            var user = _userRipository.GetUserById(id);
            var remaining = _turnoverRiposytory.remaining(user.Id);
            ViewBag.Remaining = remaining;
            return View("Profile", user);
        }
    }
}