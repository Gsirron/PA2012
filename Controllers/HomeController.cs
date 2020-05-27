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
        public IActionResult ParticipateClosed()
        {
            ViewData["Message"] = "Application's Participation Closed Page.";

            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Impact on Undergraduate Nursing Students' Digital Literacy and Health Informatics Competencies Post Implementation of a Nursing Informatics Module.";

            return View();
        }

        public IActionResult Researcher() 
        {
            ViewData["Message"] = "Application's Researchers Page.";

            return View();
        }

        public IActionResult Participate()
        {
            ViewData["Message"] = "Participate";

            ViewData["Website"] = "www.qualtrics.com";

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
        public IActionResult Phase1Student()
        {
            ViewData["Message"] = "Application's Phase 1 as Student Participate Page.";

            return View();
        }

        public IActionResult Phase1Educationalist()
        {
            ViewData["Message"] = "Application's Phase 1 as Educator Participate Page.";

            return View();
        }

        public IActionResult Phase1Academic()
        {
            ViewData["Message"] = "Application's Phase 1 as Professional Participate Page.";

            return View();
        }
        [HttpGet]
        public IActionResult Phase2PreTest()
        {
            ViewData["Message"] = "Application's Phase 2 Pre-Test Participate Page.";

            return View();
        }

        public IActionResult Phase2PostTest()
        {
            ViewData["Message"] = "Application's Phase 2 Post-Test Participate Page.";

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
