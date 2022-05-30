using Checkboxselectlistradiobutton.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Checkboxselectlistradiobutton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<IdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Langses") == null) { HttpContext.Session.SetInt32("Langses", 1); }

            ViewBag.Langses = HttpContext.Session.GetInt32("Langses");
            return View();
        }

        [HttpPost]
        public IActionResult Index(string langsesstr)
        {
            ViewBag.Langses = null;
            var langses = 0;
            if (langsesstr == "ar") { langses = 8; }
            else if (langsesstr == "tr") { langses = 1; }
            else if (langsesstr == "en") { langses = 2; }
            else if (langsesstr == "ch") { langses = 7; }
            else if (langsesstr == "fr") { langses = 3; }
            else if (langsesstr == "es") { langses = 6; }
            else if (langsesstr == "de") { langses = 4; }
            else if (langsesstr == "ru") { langses = 5; }
            HttpContext.Session.SetInt32("Langses", langses);

            var res = ViewBag.Langses = HttpContext.Session.GetInt32("Langses");
            var rescont = res;
            return View();
        }
        // [HttpPost]
        public void ChangeLanguageType(string langsesstr)
        {
            var langses = 0;
            if (langsesstr == "ar") { langses = 8; } else if (langsesstr == "tr") { langses = 1; } else if (langsesstr == "en") { langses = 2; } else if (langsesstr == "ch") { langses = 7; }

            HttpContext.Session.SetInt32("Langses", langses);
            ViewBag.Langses = HttpContext.Session.GetInt32("Langses");
            //return View();
        }


        public IActionResult List()
        {
            return View(_userManager.Users.ToList());
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
