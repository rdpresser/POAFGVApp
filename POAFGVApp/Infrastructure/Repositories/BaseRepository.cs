using POAFGVApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using POAFGVApp.Infrastructure.Configuration;
using SQLiteNetExtensions.Extensions;

namespace POAFGVApp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        public object _lock = new object();

        public BaseRepository()
        {
            if (App.AppSQLiteConn == null)
                App.AppSQLiteConn = DBContext.Instance;

            SetubDB();
        }

        void SetubDB()
        {
            App.AppSQLiteConn.CreateTable<User>(SQLite.CreateFlags.None);
            App.AppSQLiteConn.CreateTable<Address>(SQLite.CreateFlags.None);
            App.AppSQLiteConn.CreateTable<Order>(SQLite.CreateFlags.None);
            App.AppSQLiteConn.CreateTable<OrderDetail>(SQLite.CreateFlags.None);
            App.AppSQLiteConn.CreateTable<Product>(SQLite.CreateFlags.None);
        }

        public void Delele(T TEntity)
        {
            try
            {
                lock (_lock)
                    App.AppSQLiteConn.Delete(TEntity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<T> GetAll()
        {
            try
            {
                lock (_lock)
                    return App.AppSQLiteConn.GetAllWithChildren<T>(recursive: true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<T> GetAllWithChildrenByPredicate(Expression<Func<T, bool>> predicate)
        {
            try
            {
                lock (_lock)
                    return App.AppSQLiteConn.GetAllWithChildren<T>(predicate, recursive: true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T GetById(int pkId)
        {
            try
            {
                var pk = App.AppSQLiteConn.Table<T>().FirstOrDefault(x => x.Id == pkId);
                if (pk != null)
                    return App.AppSQLiteConn.GetWithChildren<T>(pk, recursive: true);

                throw new ArgumentException("Chave inválida ou inexistente", nameof(pk));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T GetWithChildrenByPredicate(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Insert(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
