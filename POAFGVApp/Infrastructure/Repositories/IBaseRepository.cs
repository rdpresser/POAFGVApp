using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POAFGVApp.Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T Entity);
        void Delele(T Entity);
        void Update(T Entity);

        T GetById(int pkId);
        T GetWithChildrenByPredicate(Expression<Func<T, bool>> predicate);

        List<T> GetAll();
        List<T> GetAllWithChildrenByPredicate(Expression<Func<T, bool>> predicate);
    }
}
