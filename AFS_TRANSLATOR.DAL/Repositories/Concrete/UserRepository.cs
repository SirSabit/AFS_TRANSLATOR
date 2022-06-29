using AFS_TRANSLATOR.CORE.CoreRepository.Concrete;
using AFS_TRANSLATOR.DAL.DBConnections;
using AFS_TRANSLATOR.DAL.Repositories.Abstract;
using AFS_TRANSLATOR.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DAL.Repositories.Concrete
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        public UserRepository(PgDbContext dbContext):base (dbContext)
        {

        }
    }
}
