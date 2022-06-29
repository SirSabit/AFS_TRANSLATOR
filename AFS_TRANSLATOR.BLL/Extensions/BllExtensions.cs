using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Concrete;
using AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract;
using AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Concrete;
using AFS_TRANSLATOR.DAL.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace AFS_TRANSLATOR.BLL.Extensions
{
    public static class BllExtensions
    {
        public static void IncludeBllServices(this IServiceCollection services)
        {
            services.IncludeDalServices();
            services.AddScoped<ILeetTranslate, LeetTranslate>();
            services.AddScoped<ITranslationHistoryServices, TranslationHistoryServices>();
        }
    }
}
