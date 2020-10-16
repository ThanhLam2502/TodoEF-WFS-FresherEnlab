using System;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetByID(int Id);
        void Insert(TEntity entity);
        void Remove(object id);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}
