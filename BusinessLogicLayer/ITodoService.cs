using DataAccessLayer;
using DataAccessLayer.Entity;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface ITodoService
    {
        List<Todo> GetTaskByStatus(Status status);
        void SetStatusByLstName(Todo task, string name);
        void AddTask(Todo task);
    }
}
