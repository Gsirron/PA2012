using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prototype.Areas.Admin.Models;
using Prototype.Areas.Identity.Data;
using Prototype.Models;

namespace Prototype.Areas.Admin.Controllers

{
    [Area("Admin")]

    public class HomeController : Controller
    {
        private readonly PrototypeContext UserManager;

        public HomeController(PrototypeContext userManager)
        {
            this.UserManager = userManager;
        }


        public async Task<IActionResult> ListUsers()
        {
            var participants = from m in UserManager.Participant
                               select m;


            ViewData["Title"] = "Participants";

            return View(await participants.ToListAsync());
        }
        
        public IActionResult Index()
        {
            var users = UserManager.Users;

            return View(users);
        }

       
    }
}