using BLL.DtoModels;
using BLL.Interfaces;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PL.Controllers
{

    public class AutorController : Controller
    {
        private IAutorService _autorService;
        private readonly ILogger<AutorController> _logger;
        public AutorController(ILogger<AutorController> logger, IAutorService autorService)
        {
            this._autorService = autorService;
            this._logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var autor = _autorService.GetAutors(c => true);
            return View(ViewData["autor"] = autor);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AutorModel model)
        {
            _autorService.AddAutor(model);
            return RedirectToAction("Index");
            //return View("WievCourser");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var autor = _autorService.GetAutorById(Id);
            return View(autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, AutorModel model)
        {
            _autorService.UpdateAutor(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var course = _autorService.GetAutorById(Id);
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, CourseModel model)
        {
            _autorService.RemoveAutor(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var course = _autorService.GetAutorById(Id);
            return View(course);
        }

    }
}
