using AFS_TRANSLATOR.DAL.DBConnections;
using AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Abstract;
using AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Concrete;
using AFS_TRANSLATOR.DAL.Repositories.Abstract;
using AFS_TRANSLATOR.DAL.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace AFS_TRANSLATOR.DAL.Extensions
{
    public static class DalExtensions
    {
        public static void IncludeDalServices(this IServiceCollection services)
        {
            services.AddDbContext<PgDbContext>();
            services.AddScoped<ITranslationHistoryRepository, TranslationHistoryRepository>();
            services.AddScoped<ITranslateApiCalls, TranslateApiCalls>();
        }
    }
}
