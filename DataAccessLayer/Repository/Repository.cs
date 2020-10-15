using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DataAccessLayer.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }
        // Expression<Func<TEntity, bool>> filter: cho phép bạn truyền vào một filter expression dạng LINQ
        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            // Query là 1 dạng IQueryable, chỉ được thực thi khi cần giá trị list
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Tiếp theo, nó sẽ kèm theo các property cần thiết khi người dùng chỉ định
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            // Sau cùng, nó thực thi bằng cách translate thành câu lệnh SQL và gọi xuống database
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
        public TEntity GetByID(int Id)
        {
            return dbSet.Find(Id);
        }
        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }
        public void Remove(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
        }
        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }
        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
