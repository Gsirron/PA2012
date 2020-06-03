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

        public async Task<IActionResult> ViewWebsite(int userId)
        {
            var sitedata = await _context.SiteData.FirstOrDefaultAsync(x => x.SiteData_Active == true);
            var particpant = await _context.Participant.FirstOrDefaultAsync(x => x.ParticipantId == userId);

            ViewData["website"] = sitedata.SiteData_Link;
            ViewData["websiteLink"] = ViewData["website"] +"?UserId="+ userId+ "&UserEmail="+ particpant.Participant_Email;
            return View();
        }
        
        public bool ValidateForm(IFormCollection Form)

        {
            if (!String.IsNullOrEmpty(Form["validation3"]))

            {
                if(Form["validation3"] == "no")
                {
                    return false;
                }
            }
            if (Form["validation"] == "no" || Form["validation2"] == "no")
            {
                return false;
            }
            return true;
        }
        public async Task<string> Randomisation(IFormCollection Form)
        {
            int countA = 0;
            int countB = 0;

            string gender = Form["gender"];
            int age = int.Parse(Form["age"]);
            string group = null;

            

            foreach (var number in _context.Participant) //count number of same type participant in each group
            {
                if (number.Participant_Age == age && number.Participant_Gender == gender && number.Participant_Group == "A")
                {
                    countA = countA + 1;
                }
                else if (number.Participant_Age == age && number.Participant_Gender == gender && number.Participant_Group == "B")
                {
                    countB = countB + 1;
                }
            }

            if (countA == countB)
            {
                assignGroupRandomly();
            }
            else if (countA > countB)
            {
                group = "B";
            }
            else if (countB > countA)
            {
                group = "A";
            }

            void assignGroupRandomly()
            {
                Random random = new Random(); //Generate random number
                int randomNumber = random.Next(0, 2); //Range of random number from 0 to 1

                if (randomNumber == 0)
                {
                    group = "A";
                }
                else
                {
                    group = "B";
                }
            }

            return group;
        }


        [HttpPost]
        public async Task<IActionResult> CreateNewParticipant(IFormCollection Form)
        {
            if (ValidateForm(Form) == false)
                {
                    return RedirectToAction("ValidFail","Home",new {fail =  "FAILED ELIGIBLE" });
                }

            Participant participant = new Participant();
            participant.Participant_Email = Form["email"];
            participant.Participant_Gender = Form["gender"];
            participant.Participant_Age = int.Parse(Form["age"]);
            participant.Participant_Phase = int.Parse(Form["phase"]);
           
            if(Form["group"] == "p2pre")
            {
                var group = await Randomisation(Form);
                participant.Participant_Group = group;
            }
            else
            {
                participant.Participant_Group = Form["group"];

            }

            if (!ParticipantExists(participant))
            {
                _context.Add(participant);
                await _context.SaveChangesAsync();
                var userId = participant.ParticipantId;
                return RedirectToAction("ViewWebsite",new { userId });
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

        public async Task <IActionResult>Index()
        {
            var sitedata = await _context.SiteData.FirstOrDefaultAsync(x => x.SiteData_Active == true);

            return View(sitedata);
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
