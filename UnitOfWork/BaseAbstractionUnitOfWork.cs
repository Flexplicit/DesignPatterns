using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public abstract class BaseAbstractionUnitOfWork: IBaseUnitOfWork
    {
        public abstract Task<int> SaveChangesAsync();
        
        private readonly Dictionary<Type, object> _uowCache = new();
        
        protected TRepository GetUowObject<TRepository>(Func<TRepository> repoCreationMethod)
            where TRepository : class
        {
            if (_uowCache.TryGetValue(typeof(TRepository), out var repo))
            {
                return (TRepository) repo;
            }

            var repoInstance = repoCreationMethod();
            _uowCache.Add(typeof(TRepository), repoInstance);
            return repoInstance;
        }
    }
}