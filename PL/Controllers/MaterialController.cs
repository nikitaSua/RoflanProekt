using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Controllers
{
    public class MaterialController : Controller
    {
        private readonly ILogger<MaterialController> _logger;

        private readonly IMaterialService _materialService;

        public MaterialController(ILogger<MaterialController> logger, IMaterialService materialService)
        {
            _logger = logger;
            this._materialService = materialService;
        }

        [HttpGet]
        public IActionResult GetMaterials()
        {
            var materials = _materialService.GetMaterials(x => true);
            return View(ViewData["materials"] = materials);
        }
    }
}
