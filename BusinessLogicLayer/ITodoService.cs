using DataAccessLayer;
using DataAccessLayer.Entity;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface ITodoService
    {
        List<Todo> GetTodoByStatus(Status status);
        void SetStatusByLstName(Todo task, string name);
        void AddTodo(Todo task);
        void Dispose();
    }
}
