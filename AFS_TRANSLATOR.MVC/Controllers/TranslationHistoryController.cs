using AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract;
using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFS_TRANSLATOR.MVC.Controllers
{
    public class TranslationHistoryController : Controller
    {
        private readonly ITranslationHistoryServices _translationHistoryServices;
        public TranslationHistoryController(ITranslationHistoryServices translationHistoryServices)
        {
            _translationHistoryServices = translationHistoryServices;
        }

        
        public IActionResult Index()
        {
            var historyList = _translationHistoryServices.GetHistoryTranslations(new TranslationHistoryFilterRequestDTO());
            List<TranslationHistoryViewModel> translations = new List<TranslationHistoryViewModel>();
            foreach (var translation in historyList.Data)
            {
                translations.Add(new TranslationHistoryViewModel
                {
                    Id=translation.Id,
                    Text=translation.Text,
                    CreatedAt=translation.CreatedAt,
                    Translation=translation.Translation,
                    TranslationType=translation.TranslationType,
                    UpdatedAt=translation.UpdatedAt,
                });
            }
            return View(translations);
        }

        [HttpPost]
        public IActionResult Index(FilterTranslationHistoryViewModel filter)
        {
            var historyList = _translationHistoryServices.GetHistoryTranslations(new TranslationHistoryFilterRequestDTO
            {
                Id = filter.Id,
                MaxDate=filter.MaxDate,
                MinDate=filter.MinDate,
                Text=filter.Text,
                Translation = filter.Translation,
            });
            List<TranslationHistoryViewModel> translations = new List<TranslationHistoryViewModel>();
            foreach (var translation in historyList.Data)
            {
                translations.Add(new TranslationHistoryViewModel
                {
                    Id = translation.Id,
                    Text = translation.Text,
                    CreatedAt = translation.CreatedAt,
                    Translation = translation.Translation,
                    TranslationType = translation.TranslationType,
                    UpdatedAt = translation.UpdatedAt,
                });
            }
            return View(translations);
        }
    }
}
