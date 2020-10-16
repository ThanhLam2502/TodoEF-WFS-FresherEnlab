using System.Linq;
using DataAccessLayer.Data;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Repository
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        public TodoRepository(TodoContext todoContext) : base(todoContext)
        {
        }
        public void AddTodo(Todo task)
        {
            Insert(task);
        }
        public IQueryable<Todo> GetTodoByStatus(Status status)
        {
            return Get(filter: s => s.Status == status, orderBy: s => s.OrderBy(sb => sb.CreatedDate));
        }
        public void UpdateStatusByID(Todo task)
        {
            Update(task);
        }
        public TodoContext TodoContext => _context as TodoContext;
    }
}

//Update
//(from p in TodoContext.Todos
// where p.ID == task.ID
// select p).ToList()
//            .ForEach(x => x.Status = task.Status);

//TodoContext.Todos.Attach(task);
//_context.Entry(task).Property(x => x.Status).IsModified = true;
//_context.SaveChanges();
