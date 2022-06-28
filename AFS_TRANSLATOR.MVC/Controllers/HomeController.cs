using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AFS_TRANSLATOR.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILeetTranslate _leetTranslate;

        public HomeController(ILogger<HomeController> logger,ILeetTranslate leetTranslate)
        {
            _leetTranslate = leetTranslate;
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            _leetTranslate.TranslateToLeet(new DTO.Request.LeetTranslateRequestDTO() { Text = "Hello World" });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}