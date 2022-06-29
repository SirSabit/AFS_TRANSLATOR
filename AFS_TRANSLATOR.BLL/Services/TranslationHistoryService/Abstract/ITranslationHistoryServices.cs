using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract
{
    public interface ITranslationHistoryServices
    {
        BaseResponseDTO InsertTranslationData(InsertTranslationDataRequestDTO request);

        BaseResponseWithDataDTO<List<HistoryTranslationDTO>> GetHistoryTranslations(TranslationHistoryFilterRequestDTO filter);
    }
}
