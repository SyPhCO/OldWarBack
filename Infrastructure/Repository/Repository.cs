using Core;
using Core.Repositories;
using Domain.Abstract;
using Domain.Interface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, InterfaceIdentity
    {
        #region field
        private readonly Context _context;
        #endregion

        #region Constructor
        public Repository(Context context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task AddAsync(TEntity entity)
        {
            UpdateInfo(entity);
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            foreach(var entity in entities)
                UpdateInfo(entity);
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }
        #endregion

        #region Read
        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().SingleAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public Task<IEnumerable<TEntity>> FindAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> SingleOrDefaultAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public void Update(TEntity entity)
        {
            UpdateInfo(entity, true);
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach(var entity in entities) UpdateInfo(entity);
            _context.Set<TEntity>().UpdateRange(entities);
            _context.SaveChanges();
        }
        #endregion

        #region Remove
        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
        #endregion

        #region Private Method
        private void UpdateInfo(TEntity entity, bool edit = false)
        {
            entity.UserModification = "System";
            entity.DateModification = DateTime.Now;

            if(!edit)
            {
                entity.UserCreation = "System";
                entity.DateCreation = DateTime.Now;
            }
        }
        #endregion

        #region Properties
        public IUnitOfWork UnitOfWork => (IUnitOfWork)_context;
        #endregion
    }
}
