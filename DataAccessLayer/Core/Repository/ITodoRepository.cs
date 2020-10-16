using System.Linq;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Repository
{
    public interface ITodoRepository : IRepository<Todo>
    {
        void AddTodo(Todo task);
        IQueryable<Todo> GetTodoByStatus(Status status);
        void UpdateStatusByID(Todo task);
    }
}