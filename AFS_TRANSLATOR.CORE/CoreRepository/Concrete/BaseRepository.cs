using AFS_TRANSLATOR.CORE.CoreRepository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AFS_TRANSLATOR.CORE.CoreRepository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : CoreEntity
    {
        private DbContext _dbContext;
        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<T> GetAll()
        {
            try
            {
                return _dbContext.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T GetByExpression(Func<T, bool> Expression)
        {
            try
            {
                return _dbContext.Set<T>().Where(Expression).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Insert(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Added;
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
