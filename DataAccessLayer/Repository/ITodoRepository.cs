using DataAccessLayer.Entity;
using System.Collections.Generic;

namespace DataAccessLayer.Repository
{
    public interface ITodoRepository : IRepository<Todo>
    {
        void AddTask(Todo task);
        List<Todo> GetTaskByStatus(Status status);
        void UpdateStatusByID(Todo task);
    }
}