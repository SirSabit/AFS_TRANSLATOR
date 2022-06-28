using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Abstract;
using AFS_TRANSLATOR.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Concrete
{
    public class LeetTranslate : ILeetTranslate
    {
        private const string _endpoint = "leetspeak";

        ITranslateApiCalls _call;
        public LeetTranslate(ITranslateApiCalls call)
        {
            _call = call;
        }

        public void TranslateToLeet(LeetTranslateRequestDTO request)
        {
            try
            {
                dynamic req = new { text = request.Text };
                var a = _call.Translate(_endpoint, req);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
