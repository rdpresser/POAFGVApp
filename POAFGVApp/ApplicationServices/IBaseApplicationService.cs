using POAFGVApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POAFGVApp.ApplicationServices
{
    public interface IBaseApplicationService<T> where T : BaseEntity
    {
        Task<int> InsertAsync(T Entity);
        Task DeleleAsync(T Entity);
        Task UpdateAsync(T Entity);

        Task<T> GetByIdAsync(int pkId);
        Task<T> GetWithChildrenByPredicateAsync(Expression<Func<T, bool>> predicate);

        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllWithChildrenByPredicateAsync(Expression<Func<T, bool>> predicate);

        Task<T> GetRemoteData();
        Task<List<T>> GetAllRemoteData();
    }
}
