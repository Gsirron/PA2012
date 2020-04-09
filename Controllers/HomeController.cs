using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prototype.Models;

namespace Prototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Application's Description Page.";

            return View();
        }

        public IActionResult Researcher() 
        {
            ViewData["Message"] = "Application's Researchers Page.";

            return View();
        }

        public IActionResult Participate()
        {
            ViewData["Message"] = "Application's Participate Page.";

            return View();
        }

        public IActionResult Report()
        {
            ViewData["Message"] = "Application's Reports Page.";

            return View();
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
