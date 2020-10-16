using DataAccessLayer.Data;
using DataAccessLayer.Repository;
using System;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TodoContext _todoContext;
        public ITodoRepository TodoRepository { get; private set; }
        public UnitOfWork(TodoContext todoContext)
        {
            _todoContext = todoContext;
            InitRepositories();
        }
        private void InitRepositories()
        {
            TodoRepository = new TodoRepository(_todoContext);
        }
        public int Complete()
        {
            return _todoContext.SaveChanges();
        }
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _todoContext.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}