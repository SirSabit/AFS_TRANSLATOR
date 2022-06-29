using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract
{
    public interface ILeetTranslate
    {
        BaseResponseWithDataDTO<TranslateToLeetResponseDTO> TranslateToLeet(LeetTranslateRequestDTO request);
    }
}
