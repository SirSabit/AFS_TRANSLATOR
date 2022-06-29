namespace AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Abstract
{
    public interface ITranslateApiCalls
    {
        Task<dynamic> Translate(string endpoint, dynamic body);
    }
}
