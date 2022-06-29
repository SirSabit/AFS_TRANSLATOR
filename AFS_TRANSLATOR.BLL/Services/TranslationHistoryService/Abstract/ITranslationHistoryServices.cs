using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.DTO.Response;

namespace AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract
{
    public interface ITranslationHistoryServices
    {
        BaseResponseDTO InsertTranslationData(InsertTranslationDataRequestDTO request);

        BaseResponseWithDataDTO<List<HistoryTranslationDTO>> GetHistoryTranslations(TranslationHistoryFilterRequestDTO filter);
    }
}
