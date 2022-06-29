using AFS_TRANSLATOR.CORE.CoreRepository.Concrete;
using AFS_TRANSLATOR.DAL.DBConnections;
using AFS_TRANSLATOR.DAL.Repositories.Abstract;
using AFS_TRANSLATOR.ENTITIES;

namespace AFS_TRANSLATOR.DAL.Repositories.Concrete
{
    public class TranslationHistoryRepository : BaseRepository<TranslationHistory>, ITranslationHistoryRepository
    {
        public TranslationHistoryRepository(PgDbContext dbContext) : base(dbContext)
        {
        }
    }
}
