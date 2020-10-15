using DataAccessLayer.Data;
using DataAccessLayer.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        public TodoRepository(TodoContext todoContext) : base(todoContext)
        {
        }
        public void AddTask(Todo task)
        {
            Insert(task);
            TodoContext.SaveChanges();
        }

        public List<Todo> GetTaskByStatus(Status status)
        {
            return TodoContext.Todos.Where(_ => _.Status == status).ToList();
        }

        public void UpdateStatusByID(Todo task)
        {
            //(from p in TodoContext.Todos
            // where p.ID == task.ID
            // select p).ToList()
            //            .ForEach(x => x.Status = task.Status);

            //TodoContext.Todos.Attach(task);
            //_context.Entry(task).Property(x => x.Status).IsModified = true;
            //_context.SaveChanges();

            Update(task);
            TodoContext.SaveChanges();
        }

        public TodoContext TodoContext
        {
            get { return _context as TodoContext; }
        }
    }
}
