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
    public class ArticleController : Controller
    {
        private readonly ILogger<MaterialController> _logger;

        private readonly IMaterialService _materialService;

        public ArticleController(ILogger<MaterialController> logger, IMaterialService materialService)
        {
            _logger = logger;
            this._materialService = materialService;
        }

        [HttpGet]
        public IActionResult WievArticle()
        {
            var article = _materialService.GetArticles(b => true);
            return View(ViewData["article"] = article);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ArticleModel model)
        {
            _materialService.AddArticle(model);
            return RedirectToAction("WievArticle");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var article = _materialService.GetArticle(x=>x.Id== Id);
            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, ArticleModel model)
        {
            _materialService.UpdateArticle(Id, model);
            return RedirectToAction("WievArticle");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var articles = _materialService.GetArticle(x => x.Id == Id);
            return View(articles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, ArticleModel model)
        {
            _materialService.RemoveMaterial(Id);
            return RedirectToAction("WievArticle");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var article = _materialService.GetArticle(x => x.Id == Id);
            return View(article);
        }
    }
}
