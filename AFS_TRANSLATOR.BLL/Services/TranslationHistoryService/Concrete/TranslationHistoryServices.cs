using AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Abstract;
using AFS_TRANSLATOR.DAL.Repositories.Abstract;
using AFS_TRANSLATOR.DTO.Request;
using AFS_TRANSLATOR.DTO.Response;
using AFS_TRANSLATOR.ENTITIES;

namespace AFS_TRANSLATOR.BLL.Services.TranslationHistoryService.Concrete
{
    public class TranslationHistoryServices : ITranslationHistoryServices
    {
        ITranslationHistoryRepository _repository;
        public TranslationHistoryServices(ITranslationHistoryRepository repository)
        {
            _repository = repository;
        }

        public BaseResponseDTO InsertTranslationData(InsertTranslationDataRequestDTO request)
        {
            try
            {
                TranslationHistory entity = new TranslationHistory { Text = request.Text, Translation = request.Translation, TranslationType = request.TranslationType, CreatedAt = DateTime.Now };

                _repository.Insert(entity);

                return new BaseResponseDTO { StatusCode = 201, Message = "Success" };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while recording TranslationData\n Reason: {ex.Message}");
            }
        }

        public BaseResponseWithDataDTO<List<HistoryTranslationDTO>> GetHistoryTranslations(TranslationHistoryFilterRequestDTO filter)
        {
            try
            {
                List<HistoryTranslationDTO> translationList = new List<HistoryTranslationDTO>();

                var translationHistoryList = _repository.GetAll();

                translationHistoryList = filter.MinDate == DateTime.MinValue ? translationHistoryList : translationHistoryList.Where(x => x.CreatedAt >= filter.MinDate).ToList();
                translationHistoryList = filter.MaxDate == DateTime.MaxValue ? translationHistoryList : translationHistoryList.Where(x => x.CreatedAt <= filter.MinDate).ToList();
                translationHistoryList = filter.Text == "" || filter.Text == null ? translationHistoryList : translationHistoryList.Where(x => x.Text.ToLower().Contains(filter.Text.ToLower())).ToList();
                translationHistoryList = filter.Translation == "" || filter.Translation == null ? translationHistoryList : translationHistoryList.Where(x => x.Translation.ToLower().Contains(filter.Translation.ToLower())).ToList();
                translationHistoryList = filter.TranslationType == "" || filter.TranslationType == null ? translationHistoryList : translationHistoryList.Where(x => x.TranslationType.ToLower().Contains(filter.TranslationType.ToLower())).ToList();


                foreach (var translation in translationHistoryList)
                {
                    translationList.Add(new HistoryTranslationDTO
                    {
                        Id = translation.Id,
                        Text = translation.Text,
                        Translation = translation.Translation,
                        TranslationType = translation.TranslationType,
                        CreatedAt = translation.CreatedAt
                    });
                }
                return new BaseResponseWithDataDTO<List<HistoryTranslationDTO>>()
                {
                    Data = translationList,
                    StatusCode = 200,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while retrieving translations TranslationData\n Reason: {ex.Message}");
            }
        }
    }
}
