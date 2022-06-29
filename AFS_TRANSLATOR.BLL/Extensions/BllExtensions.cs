using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Concrete;
using AFS_TRANSLATOR.DAL.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.BLL.Extensions
{
    public static class BllExtensions
    {
        public static void IncludeBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.IncludeDalServices(configuration);
            services.AddScoped<ILeetTranslate, LeetTranslate>();
        }
    }
}
