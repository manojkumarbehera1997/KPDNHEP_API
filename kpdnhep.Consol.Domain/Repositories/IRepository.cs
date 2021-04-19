using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(long id);
        Task<T> InsertOrUpdate(T entity);
        Task<int> Delete(long id);
    }

}
