using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public class TodoRepository : ITodoRepository, IDisposable
    {
        public TodoRepository()
        {

        }
        public void DeleteTodo(int todoID)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodoByID(int todoId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetTodos()
        {
            throw new NotImplementedException();
        }

        public void InsertTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
