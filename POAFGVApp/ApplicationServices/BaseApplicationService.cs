﻿using POAFGVApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using POAFGVApp.Infrastructure.Repositories;

namespace POAFGVApp.ApplicationServices
{
    public class BaseApplicationService<T>
        : IBaseApplicationService<T> where T : BaseEntity, new()
    {

        IBaseRepository<T> _repository { get; }

        public BaseApplicationService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task DeleleAsync(T TEntity)
        {
            await Task.Run(() => _repository.Delele(TEntity));
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Task.Run(() => _repository.GetAll());
        }

        public async Task<List<T>> GetAllWithChildrenByPredicateAsync(Expression<Func<T, bool>> predicate)
        {
            return await Task.Run(() => _repository.GetAllWithChildrenByPredicate(predicate));
        }

        public async Task<T> GetByIdAsync(int pkId)
        {
            return await Task.Run(() => _repository.GetById(pkId));
        }

        public Task<T> GetRemoteData()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetWithChildrenByPredicateAsync(Expression<Func<T, bool>> predicate)
        {
            return await Task.Run(() => _repository.GetWithChildrenByPredicate(predicate));
        }

        public async Task<int> InsertAsync(T TEntity)
        {
            T entity;
            try
            {
                await Task.Run(() => _repository.Insert(TEntity));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                entity = (await this.GetAllAsync()).Last();
            }

            return entity != null ? entity.Id : -1;
        }

        public Task UpdateAsync(T Entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllRemoteData()
        {
            throw new NotImplementedException();
        }
    }
}
