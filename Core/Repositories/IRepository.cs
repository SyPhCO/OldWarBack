using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, InterfaceIdentity
    {
        IUnitOfWork UnitOfWork { get; }

        //#region Read
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        //#endregion

        //#region Create
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        //#endregion

        //#region Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        //#endregion

        //#region Remove
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        //#endregion
    }
}
