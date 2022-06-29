using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Abstract
{
    public interface ITranslateApiCalls
    {
        Task<dynamic> Translate(string endpoint, dynamic body);
    }
}
