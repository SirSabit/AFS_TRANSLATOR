using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.DTO.Response;

namespace AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract
{
    public interface ILeetTranslate
    {
        BaseResponseWithDataDTO<TranslateToLeetResponseDTO> TranslateToLeet(LeetTranslateRequestDTO request);
    }
}
