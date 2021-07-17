using BLL.DtoModels;
using BLL.Interfaces;
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
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;

        private readonly ICourseService _courseService;

        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
        {
            _logger = logger;
            this._courseService = courseService;
        }

        [HttpGet]
        public IActionResult WievCourser()
        {
            var courses = _courseService.GetCourses(c => true);
            return View(ViewData["courses"] = courses);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CourseModel model)
        {
            _courseService.AddCourse(model);
            return RedirectToAction("WievCourser");
            //return View("WievCourser");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var course = _courseService.GetCourseById(Id);
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, CourseModel model)
        {
            _courseService.UpdateCourse(Id, model);
            return RedirectToAction("WievCourser");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var course=_courseService.GetCourseById(Id);
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, CourseModel model)
        {
            _courseService.RemoveCourse(Id);
            return RedirectToAction("WievCourser");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var course = _courseService.GetCourseById(Id);
            return View(course);
        }



    }
}
