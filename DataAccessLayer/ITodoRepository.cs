using Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ITodoRepository :IDisposable
    {
        IEnumerable<Todo> GetTodos();
        Todo GetTodoByID(int todoId);
        void InsertTodo(Todo todo);
        void DeleteTodo(int todoID);
        void UpdateTodo(Todo todo);
        void Save();
    }
}
