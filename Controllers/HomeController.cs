using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Prototype.Areas.Admin.Models;
using Prototype.Models;
using SQLitePCL;

namespace Prototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly PrototypeContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,PrototypeContext context)
        {
            _context = context;
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

        public IActionResult Test(IFormCollection Form)
        {
            if(Form["validation"] == "no")
            {
                return RedirectToAction(nameof(About));
            }


            return RedirectToAction(nameof(Index));
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

        public IActionResult ValidFail(string fail = null)
        {   
            if(fail !=null)
            {
                ViewData["Fail"] = fail;

                return View();
            }

            ViewData["Fail"] = "Sorry you are not Eilgiable";

            return View();
        }

        public async Task<IActionResult> ViewWebsite()
        {
            var sitedata = await _context.SiteData.FirstOrDefaultAsync(x => x.SiteData_Active == true);

            ViewData["website"] = sitedata.SiteData_Link;

            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> CreateNewParticipant(IFormCollection Form)
        {
            if (Form["validation"] == "no" ||  Form["validation2"] == "no")
                {
                    return RedirectToAction("ValidFail","Home",new {fail =  "FAILED ELIGIBLE" });
                }

            Participant participant = new Participant();
            participant.Participant_Email = Form["email"];
            participant.Participant_Gender = Form["gender"];
            participant.Participant_Age = int.Parse(Form["age"]);
            participant.Participant_Phase = int.Parse(Form["phase"]);
            participant.Participant_Group = Form["group"];

            if (!ParticipantExists(participant))
            {
                _context.Add(participant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ViewWebsite));
            }
            return RedirectToAction("ValidFail", "Home", new { fail = "Already taken Survey" });

        }

        private bool ParticipantExists(Participant participant)
        {
            return _context.Participant.Any(e => e.Participant_Email == participant.Participant_Email && e.Participant_Group == participant.Participant_Group &&
            e.Participant_Phase == participant.Participant_Phase);
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
