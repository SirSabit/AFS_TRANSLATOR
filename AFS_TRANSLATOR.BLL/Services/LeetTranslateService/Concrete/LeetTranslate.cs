using AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract;
using AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Abstract;
using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.DTO.Response;
using Newtonsoft.Json;
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

        public BaseResponseWithDataDTO<TranslateToLeetResponseDTO> TranslateToLeet(LeetTranslateRequestDTO request)
        {
            try
            {
                dynamic req = new { text = request.Text };

                var apiResult = _call.Translate(_endpoint, req);

                if (apiResult.Result.error != null)
                {
                    return new BaseResponseWithDataDTO<TranslateToLeetResponseDTO>()
                    {
                        StatusCode = apiResult.Result.error.code,                        
                        Message = apiResult.Result.error.message
                    };
                }

                TranslateToLeetResponseDTO data = new TranslateToLeetResponseDTO { Text = apiResult.Result.contents.text,Translated= apiResult.Result.contents.translated, Translation =apiResult.Result.contents.translation };

                return new BaseResponseWithDataDTO<TranslateToLeetResponseDTO>()
                {
                    StatusCode=200,
                    Data=data,
                    Message="Success"
                };

            }
            catch (Exception ex)
            {
                throw new Exception($"Error while api call for leet translate\n Reason: {ex.Message}");
            }
        }
    }
}
