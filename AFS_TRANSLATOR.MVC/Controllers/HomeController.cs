using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract;
using AFS_TRANSLATOR.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AFS_TRANSLATOR.MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ITranslationHistoryServices _translationHistoryServices;
        private readonly ILeetTranslate _leetTranslate;

        public HomeController(ITranslationHistoryServices translationHistoryServices, ILeetTranslate leetTranslate)
        {
            _leetTranslate = leetTranslate;
            _translationHistoryServices = translationHistoryServices;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            //var result = _leetTranslate.TranslateToLeet(new DTO.Request.LeetTranslateRequestDTO() { Text = "Hello World" });
            _translationHistoryServices.InsertTranslationData(new DTO.Request.InsertTranslationDataRequestDTO() { Text = "result.Data.Text" , Translation="result.Data.Translation", TranslationType= "result.Data.Translated"});
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}