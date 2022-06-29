using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.CORE.CoreRepository.Abstract
{
    public interface IBaseRepository<T>
        where T : CoreEntity
    {
        void Insert(T entity);
        void Update(T entity);
        T GetByExpression(Func<T, bool> Expression);

        List<T> GetAll();
    }
}
