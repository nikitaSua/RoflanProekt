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
    public class VideoController:Controller
    {
        private readonly ILogger<MaterialController> _logger;

        private readonly IMaterialService _materialService;

        public VideoController(ILogger<MaterialController> logger, IMaterialService materialService)
        {
            _logger = logger;
            this._materialService = materialService;
        }
        [HttpGet]
        public IActionResult WievVideo()
        {
            var videos = _materialService.GetVideos(b => true);
            return View(ViewData["video"] = videos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VideoModel model)
        {
            _materialService.AddVideo(model);
            return RedirectToAction("WievVideo");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var video = _materialService.GetVideo(x => x.Id == Id);
            return View(video);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, VideoModel model)
        {
            _materialService.UpdateVideo(Id, model);
            return RedirectToAction("WievVideo");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var videos = _materialService.GetVideo(x => x.Id == Id);
            return View(videos);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, VideoModel model)
        {
            _materialService.RemoveMaterial(Id);
            return RedirectToAction("WievVideo");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var videos = _materialService.GetVideo(x => x.Id == Id);
            return View(videos);
        }
    }
}
