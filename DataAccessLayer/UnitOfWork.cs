using DataAccessLayer.Data;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private TodoContext _todoContext;
        public UnitOfWork(TodoContext todoContext)
        {
            _todoContext = todoContext;
            TodoRepository = new TodoRepository(_todoContext);
        }

        public ITodoRepository TodoRepository { get; private set; }

        public int Complete()
        {
            return _todoContext.SaveChanges();
        }

        public void Dispose()
        {
            _todoContext.Dispose();
        }
    }
}
