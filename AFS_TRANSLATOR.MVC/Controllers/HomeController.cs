using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract;
using AFS_TRANSLATOR.DTO.Request;
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

        [HttpGet]
        public IActionResult Index()
        {
            LeetTranslateResponseViewModel response = new LeetTranslateResponseViewModel();
            return View(response);
        }
        [HttpPost]
        public IActionResult Index(LeetTranslateRequestViewModel model)
        {
            LeetTranslateResponseViewModel response = new LeetTranslateResponseViewModel();
            if (ModelState.IsValid)
            {
                var translation = _leetTranslate.TranslateToLeet(new LeetTranslateRequestDTO { Text = model.Text });

                if (translation.StatusCode == 200)
                {
                    _translationHistoryServices.InsertTranslationData(new InsertTranslationDataRequestDTO { Text = translation.Data.Text, Translation = translation.Data.Translated, TranslationType = translation.Data.Translation });
                    response.Translation = translation.Data.Translated;
                    return View(response);
                }
                else
                {
                    response.Message = translation.Message;
                    return View(response);
                }
            }
            return View(response);
        }
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