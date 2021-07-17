using BLL.DtoModels;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Controllers
{
    public class SkillController: Controller
    {
        private readonly ILogger<SkillController> _logger;

        private readonly ISkillService _skillService;

        public SkillController(ILogger<SkillController> logger, ISkillService skillService)
        {
            _logger = logger;
            this._skillService = skillService;
        }

        [HttpGet]
        public IActionResult WievSkill()
        {
            var skills = _skillService.GetSkills(b => true);
            return View(ViewData["skills"] = skills);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SkillModel model)
        {
            _skillService.AddSkill(model);
            return RedirectToAction("WievSkill");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var skill = _skillService.GetSkill(x=>x.Id== Id);
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, SkillModel model)
        {
            _skillService.UpdateSkill(Id, model);
            return RedirectToAction("WievSkill");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var skill = _skillService.GetSkill(x => x.Id == Id);
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, SkillModel model)
        {
            _skillService.RemoveSkill(Id);
            return RedirectToAction("WievSkill");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var skill = _skillService.GetSkill(x => x.Id == Id);
            return View(skill);
        }
    }
}
