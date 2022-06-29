using AFS_TRANSLATOR.CORE.CoreRepository.Abstract;
using AFS_TRANSLATOR.CORE.CoreRepository.Concrete;
using AFS_TRANSLATOR.DAL.DBConnections;
using AFS_TRANSLATOR.DAL.Repositories.Abstract;
using AFS_TRANSLATOR.ENTITIES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DAL.Repositories.Concrete
{
    public class RequestResponseLogRepository : BaseRepository<TranslationHistory>, IRequestResponseLogRepository
    {
        public RequestResponseLogRepository(PgDbContext dbContext) : base(dbContext)
        {
        }     
    }
}
