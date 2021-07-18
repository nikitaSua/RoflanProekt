using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  readonly IUserSkillService _userSkillService;
        private readonly IUserService _userServise;


        public HomeController(ILogger<HomeController> logger, IUserSkillService userSkillService, IUserService userServise)
        {
            _logger = logger;
            this._userSkillService = userSkillService;
            this._userServise = userServise;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetUserWithSkills(int id)
        {
            var skills =_userSkillService.GetUserSkills(x => x.UserId == id);

            return View(ViewData["user_skills"]= skills);
        }


        [Authorize(Roles = "Admin")]
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
