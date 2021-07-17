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
    public class BookController: Controller
    {
        private readonly ILogger<MaterialController> _logger;

        private readonly IMaterialService _materialService;

        public BookController(ILogger<MaterialController> logger, IMaterialService materialService)
        {
            _logger = logger;
            this._materialService = materialService;
        }

        [HttpGet]
        public IActionResult WievBook()
        {
            var books = _materialService.GetBooks(b => true);
            return View(ViewData["books"] = books);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookModel model)
        {
            _materialService.AddBook(model);
            return RedirectToAction("WievBook");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var book = _materialService.GetBook(x=>x.Id== Id);
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, BookModel model)
        {
            _materialService.UpdateBook(Id, model);
            return RedirectToAction("WievBook");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var books = _materialService.GetBook(x => x.Id == Id);
            return View(books);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, BookModel model)
        {
            _materialService.RemoveMaterial(Id);
            return RedirectToAction("WievBook");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var books = _materialService.GetBook(x => x.Id == Id);
            return View(books);
        }
    }
}
