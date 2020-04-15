using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Prototype.Areas.Identity.Data;

namespace Prototype.Areas.Admin.Controllers

{[Area("Admin")]

    public class HomeController : Controller
    {
        private readonly UserManager<PrototypeUser> UserManager;

        public HomeController(UserManager<PrototypeUser> userManager)
        {
            this.UserManager = userManager;
        }


        public IActionResult ListUsers()
        {


            return View();
        }
        
        public IActionResult Index()
        {
            var users = UserManager.Users;

            return View(users);
        }
    }
}