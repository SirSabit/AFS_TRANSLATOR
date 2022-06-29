namespace AFS_TRANSLATOR.DTO.Response
{
    public class BaseResponseWithDataDTO<T> : BaseResponseDTO
    {
        public T Data { get; set; }
    }
}
